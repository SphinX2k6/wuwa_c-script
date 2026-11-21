using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000282 RID: 642
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkelMeshComponentLODInfo")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FSkelMeshComponentLODInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060044A9 RID: 17577 RVA: 0x00061673 File Offset: 0x0005F873
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkelMeshComponentLODInfo._ScriptStructPtr != 0) ? FSkelMeshComponentLODInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkelMeshComponentLODInfo", ref FSkelMeshComponentLODInfo._ScriptStructPtr);
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060044AA RID: 17578 RVA: 0x00061698 File Offset: 0x0005F898
		// (set) Token: 0x060044AB RID: 17579 RVA: 0x000616DB File Offset: 0x0005F8DB
		public TArray<bool> HiddenMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._HiddenMaterials) == null)
				{
					result = (this._HiddenMaterials = new TArray<bool>(base.NativePtr + (IntPtr)FSkelMeshComponentLODInfo.__PropertyOffset_HiddenMaterials, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HiddenMaterials.CopyAssign(value);
			}
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x000616E9 File Offset: 0x0005F8E9
		public FSkelMeshComponentLODInfo()
		{
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x000616F1 File Offset: 0x0005F8F1
		protected override IntPtr GetUStructPtr()
		{
			return FSkelMeshComponentLODInfo.StaticStruct();
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x000616FD File Offset: 0x0005F8FD
		[NullableContext(2)]
		public FSkelMeshComponentLODInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x00061707 File Offset: 0x0005F907
		public FSkelMeshComponentLODInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x00061712 File Offset: 0x0005F912
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkelMeshComponentLODInfo(Pointer, false, true);
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x0006171C File Offset: 0x0005F91C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkelMeshComponentLODInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04001ADD RID: 6877
		public const string __ObjectPath = "/Script/Engine.SkelMeshComponentLODInfo";

		// Token: 0x04001ADE RID: 6878
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001ADF RID: 6879
		internal static int __PropertyOffset_HiddenMaterials;

		// Token: 0x04001AE0 RID: 6880
		[Nullable(2)]
		private TArray<bool> _HiddenMaterials;
	}
}
