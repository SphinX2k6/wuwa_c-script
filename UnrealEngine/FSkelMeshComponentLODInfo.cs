using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200110E RID: 4366
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkelMeshComponentLODInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FSkelMeshComponentLODInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FD59 RID: 64857 RVA: 0x0017628F File Offset: 0x0017448F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkelMeshComponentLODInfo._ScriptStructPtr != 0) ? FSkelMeshComponentLODInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkelMeshComponentLODInfo", ref FSkelMeshComponentLODInfo._ScriptStructPtr);
		}

		// Token: 0x17003DD1 RID: 15825
		// (get) Token: 0x0600FD5A RID: 64858 RVA: 0x001762B4 File Offset: 0x001744B4
		// (set) Token: 0x0600FD5B RID: 64859 RVA: 0x001762F7 File Offset: 0x001744F7
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

		// Token: 0x0600FD5C RID: 64860 RVA: 0x00176305 File Offset: 0x00174505
		public FSkelMeshComponentLODInfo()
		{
		}

		// Token: 0x0600FD5D RID: 64861 RVA: 0x0017630D File Offset: 0x0017450D
		public FSkelMeshComponentLODInfo(TArray<bool> HiddenMaterials)
		{
			this.HiddenMaterials = HiddenMaterials;
		}

		// Token: 0x0600FD5E RID: 64862 RVA: 0x0017631C File Offset: 0x0017451C
		protected override IntPtr GetUStructPtr()
		{
			return FSkelMeshComponentLODInfo.StaticStruct();
		}

		// Token: 0x0600FD5F RID: 64863 RVA: 0x00176328 File Offset: 0x00174528
		[NullableContext(2)]
		public FSkelMeshComponentLODInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FD60 RID: 64864 RVA: 0x00176332 File Offset: 0x00174532
		public FSkelMeshComponentLODInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FD61 RID: 64865 RVA: 0x0017633D File Offset: 0x0017453D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkelMeshComponentLODInfo(Pointer, false, true);
		}

		// Token: 0x0600FD62 RID: 64866 RVA: 0x00176347 File Offset: 0x00174547
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkelMeshComponentLODInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400889C RID: 34972
		public const string __ObjectPath = "/Script/Engine.SkelMeshComponentLODInfo";

		// Token: 0x0400889D RID: 34973
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400889E RID: 34974
		internal static int __PropertyOffset_HiddenMaterials;

		// Token: 0x0400889F RID: 34975
		[Nullable(2)]
		private TArray<bool> _HiddenMaterials;
	}
}
