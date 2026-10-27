using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015D1 RID: 5585
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KawaiiPhysics.KawaiiBoneBind")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKawaiiBoneBind : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601422A RID: 82474 RVA: 0x001D9350 File Offset: 0x001D7550
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKawaiiBoneBind._ScriptStructPtr != 0) ? FKawaiiBoneBind._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.KawaiiBoneBind", ref FKawaiiBoneBind._ScriptStructPtr);
		}

		// Token: 0x17004EF2 RID: 20210
		// (get) Token: 0x0601422B RID: 82475 RVA: 0x001D9374 File Offset: 0x001D7574
		// (set) Token: 0x0601422C RID: 82476 RVA: 0x001D93B7 File Offset: 0x001D75B7
		public FBoneReference Bone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._Bone) == null)
				{
					result = (this._Bone = new FBoneReference(base.NativePtr + (IntPtr)FKawaiiBoneBind.__PropertyOffset_Bone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FKawaiiBoneBind.__PropertyOffset_Bone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004EF3 RID: 20211
		// (get) Token: 0x0601422D RID: 82477 RVA: 0x001D93D8 File Offset: 0x001D75D8
		// (set) Token: 0x0601422E RID: 82478 RVA: 0x001D941B File Offset: 0x001D761B
		public FBoneReference BindBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BindBone) == null)
				{
					result = (this._BindBone = new FBoneReference(base.NativePtr + (IntPtr)FKawaiiBoneBind.__PropertyOffset_BindBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FKawaiiBoneBind.__PropertyOffset_BindBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601422F RID: 82479 RVA: 0x001D943C File Offset: 0x001D763C
		public FKawaiiBoneBind()
		{
		}

		// Token: 0x06014230 RID: 82480 RVA: 0x001D9444 File Offset: 0x001D7644
		public FKawaiiBoneBind(FBoneReference Bone, FBoneReference BindBone)
		{
			this.Bone = Bone;
			this.BindBone = BindBone;
		}

		// Token: 0x06014231 RID: 82481 RVA: 0x001D945A File Offset: 0x001D765A
		protected override IntPtr GetUStructPtr()
		{
			return FKawaiiBoneBind.StaticStruct();
		}

		// Token: 0x06014232 RID: 82482 RVA: 0x001D9466 File Offset: 0x001D7666
		[NullableContext(2)]
		public FKawaiiBoneBind(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014233 RID: 82483 RVA: 0x001D9470 File Offset: 0x001D7670
		public FKawaiiBoneBind(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014234 RID: 82484 RVA: 0x001D947B File Offset: 0x001D767B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKawaiiBoneBind(Pointer, false, true);
		}

		// Token: 0x06014235 RID: 82485 RVA: 0x001D9485 File Offset: 0x001D7685
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKawaiiBoneBind(Pointer, MemoryOwner);
		}

		// Token: 0x0400AF3E RID: 44862
		public const string __ObjectPath = "/Script/KawaiiPhysics.KawaiiBoneBind";

		// Token: 0x0400AF3F RID: 44863
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AF40 RID: 44864
		internal static int __PropertyOffset_Bone;

		// Token: 0x0400AF41 RID: 44865
		[Nullable(2)]
		private FBoneReference _Bone;

		// Token: 0x0400AF42 RID: 44866
		internal static int __PropertyOffset_BindBone;

		// Token: 0x0400AF43 RID: 44867
		[Nullable(2)]
		private FBoneReference _BindBone;
	}
}
