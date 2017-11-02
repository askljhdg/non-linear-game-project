﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Memes are Dreams Studios. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace _3DPrimitives {
    using System.Collections.Generic;

    using UnityEngine;

    using Zenject;

    /// <inheritdoc />
    /// <summary>
    /// The sector.
    /// </summary>
    public class Sector : MonoBehaviour {
        /// <summary>
        /// The depth.
        /// </summary>
        private float depth;

        /// <summary>
        /// The height.
        /// </summary>
        private float height;

        /// <summary>
        /// The slice.
        /// </summary>
        private int slice;

        /// <summary>
        /// The mesh filter.
        /// </summary>
        private MeshFilter meshFilter;

        /// <summary>
        /// The mesh collider.
        /// </summary>
        private MeshCollider meshCollider;

        /// <summary>
        /// Gets or sets the Depth.
        /// </summary>
        public float Depth {
            get {
                return this.depth;
            }

            set {
                this.depth = value;
                this.AttachMesh();
            }
        }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        public float Height {
            get {
                return this.height;
            }

            set {
                this.height = value;
                this.AttachMesh();
            }
        }

        /// <summary>
        /// Gets or sets the Slice.
        /// </summary>
        public int Slice {
            get {
                return this.slice;
            }

            set {
                this.slice = value;
                this.AttachMesh();
            }
        }

        /// <summary>
        /// Gets or sets the transform.
        /// </summary>
        public Transform Transform { get; set; }

        /// <summary>
        /// Gets the mesh.
        /// </summary>
        public Mesh Mesh {
            get {
                var height = this.Height / 2;
                return new Mesh {
                    vertices = new[]
                    {
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, height, 0)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, height, this.depth)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, 180.0f / this.Slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, height, this.Depth)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, height, this.depth)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, height, 0)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, -height, this.Depth)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, -height, this.Depth)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, height, 0)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, -height, 0)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, height, 0)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, 180.0f / this.Slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, height, this.Depth)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, -height, 0)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, -height, 0)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, 180.0f / this.Slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, height, this.Depth)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, 180.0f / this.Slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, -height, this.Depth)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, -height, 0)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, 180.0f / this.Slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, -height, this.Depth)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, -height, this.Depth)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, 180.0f / this.Slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, -height, this.Depth)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, 180.0f / this.Slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, height, this.Depth)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, height, this.depth)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, 180.0f / this.Slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, -height, this.Depth)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, height, this.depth)),
                        Matrix4x4.Rotate(Quaternion.Euler(0, -180.0f / this.slice, 0))
                            .MultiplyPoint3x4(new Vector3(0, -height, this.Depth)),
                    },
                    triangles = new[]
                        { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 }
                };
            }
        }

        /// <summary>
        /// The construct.
        /// </summary>
        /// <param name="mf">
        /// The mf.
        /// </param>
        /// <param name="mc">
        /// The mc.
        /// </param>
        /// <param name="transform">
        /// The transform.
        /// </param>
        [Inject]
        public void Construct(MeshFilter mf, MeshCollider mc, Transform transform) {
            this.meshFilter = mf;
            this.meshCollider = mc;
            this.Transform = transform;
        }

        /// <summary>
        /// The attach mesh.
        /// </summary>
        private void AttachMesh() {
            var mesh = this.Mesh;
            this.meshFilter.sharedMesh = mesh;
            this.meshCollider.sharedMesh = mesh;
        }

        /// <summary>
        /// The pool.
        /// </summary>
        public class Pool : MonoMemoryPool<float, float, int, Sector> {
            /// <summary>
            /// The reinitialize.
            /// </summary>
            /// <param name="depth">
            /// The depth.
            /// </param>
            /// <param name="height">
            /// The height.
            /// </param>
            /// <param name="slice">
            /// The slice.
            /// </param>
            /// <param name="sector">
            /// The sector.
            /// </param>
            protected override void Reinitialize(float depth, float height, int slice, Sector sector) {
                sector.depth = depth;
                sector.height = height;
                sector.slice = slice;
                sector.AttachMesh();
            }
        }

    }
}