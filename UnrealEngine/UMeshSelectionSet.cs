using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001589 RID: 5513
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/InteractiveToolsFramework.MeshSelectionSet")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UMeshSelectionSet : USelectionSet, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E71 RID: 81521 RVA: 0x001D3962 File Offset: 0x001D1B62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMeshSelectionSet._ClassPtr;
		}

		// Token: 0x06013E72 RID: 81522 RVA: 0x001D3970 File Offset: 0x001D1B70
		public UMeshSelectionSet() : this(BuiltinUtils.AllocNativeUObject(UMeshSelectionSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E73 RID: 81523 RVA: 0x001D3998 File Offset: 0x001D1B98
		public UMeshSelectionSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMeshSelectionSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DE9 RID: 19945
		// (get) Token: 0x06013E74 RID: 81524 RVA: 0x001D39CC File Offset: 0x001D1BCC
		// (set) Token: 0x06013E75 RID: 81525 RVA: 0x001D3A05 File Offset: 0x001D1C05
		public TArray<int> Vertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Vertices) == null)
				{
					result = (this._Vertices = new TArray<int>(base.NativePtr + (IntPtr)UMeshSelectionSet.__PropertyOffset_Vertices, this));
				}
				return result;
			}
			set
			{
				this.Vertices.CopyAssign(value);
			}
		}

		// Token: 0x17004DEA RID: 19946
		// (get) Token: 0x06013E76 RID: 81526 RVA: 0x001D3A14 File Offset: 0x001D1C14
		// (set) Token: 0x06013E77 RID: 81527 RVA: 0x001D3A4D File Offset: 0x001D1C4D
		public TArray<int> Edges
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Edges) == null)
				{
					result = (this._Edges = new TArray<int>(base.NativePtr + (IntPtr)UMeshSelectionSet.__PropertyOffset_Edges, this));
				}
				return result;
			}
			set
			{
				this.Edges.CopyAssign(value);
			}
		}

		// Token: 0x17004DEB RID: 19947
		// (get) Token: 0x06013E78 RID: 81528 RVA: 0x001D3A5C File Offset: 0x001D1C5C
		// (set) Token: 0x06013E79 RID: 81529 RVA: 0x001D3A95 File Offset: 0x001D1C95
		public TArray<int> Faces
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Faces) == null)
				{
					result = (this._Faces = new TArray<int>(base.NativePtr + (IntPtr)UMeshSelectionSet.__PropertyOffset_Faces, this));
				}
				return result;
			}
			set
			{
				this.Faces.CopyAssign(value);
			}
		}

		// Token: 0x17004DEC RID: 19948
		// (get) Token: 0x06013E7A RID: 81530 RVA: 0x001D3AA4 File Offset: 0x001D1CA4
		// (set) Token: 0x06013E7B RID: 81531 RVA: 0x001D3ADD File Offset: 0x001D1CDD
		public TArray<int> Groups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Groups) == null)
				{
					result = (this._Groups = new TArray<int>(base.NativePtr + (IntPtr)UMeshSelectionSet.__PropertyOffset_Groups, this));
				}
				return result;
			}
			set
			{
				this.Groups.CopyAssign(value);
			}
		}

		// Token: 0x06013E7C RID: 81532 RVA: 0x001D3AEB File Offset: 0x001D1CEB
		static UMeshSelectionSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.MeshSelectionSet");
		}

		// Token: 0x06013E7D RID: 81533 RVA: 0x001D3AF9 File Offset: 0x001D1CF9
		protected UMeshSelectionSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC55 RID: 44117
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.MeshSelectionSet";

		// Token: 0x0400AC56 RID: 44118
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC57 RID: 44119
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AC58 RID: 44120
		internal static int __PropertyOffset_Vertices;

		// Token: 0x0400AC59 RID: 44121
		[Nullable(2)]
		private TArray<int> _Vertices;

		// Token: 0x0400AC5A RID: 44122
		internal static int __PropertyOffset_Edges;

		// Token: 0x0400AC5B RID: 44123
		[Nullable(2)]
		private TArray<int> _Edges;

		// Token: 0x0400AC5C RID: 44124
		internal static int __PropertyOffset_Faces;

		// Token: 0x0400AC5D RID: 44125
		[Nullable(2)]
		private TArray<int> _Faces;

		// Token: 0x0400AC5E RID: 44126
		internal static int __PropertyOffset_Groups;

		// Token: 0x0400AC5F RID: 44127
		[Nullable(2)]
		private TArray<int> _Groups;
	}
}
