using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002E6 RID: 742
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FAnimNode_MakeDynamicAdditive : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002A2C RID: 10796 RVA: 0x00040054 File Offset: 0x0003E254
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_MakeDynamicAdditive._ScriptStructPtr != 0) ? FAnimNode_MakeDynamicAdditive._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive", ref FAnimNode_MakeDynamicAdditive._ScriptStructPtr);
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06002A2D RID: 10797 RVA: 0x00040078 File Offset: 0x0003E278
		// (set) Token: 0x06002A2E RID: 10798 RVA: 0x000400BB File Offset: 0x0003E2BB
		public FPoseLink Base
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Base) == null)
				{
					result = (this._Base = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_MakeDynamicAdditive.__PropertyOffset_Base, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_MakeDynamicAdditive.__PropertyOffset_Base, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06002A2F RID: 10799 RVA: 0x000400DC File Offset: 0x0003E2DC
		// (set) Token: 0x06002A30 RID: 10800 RVA: 0x0004011F File Offset: 0x0003E31F
		public FPoseLink Additive
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Additive) == null)
				{
					result = (this._Additive = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_MakeDynamicAdditive.__PropertyOffset_Additive, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_MakeDynamicAdditive.__PropertyOffset_Additive, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06002A31 RID: 10801 RVA: 0x00040140 File Offset: 0x0003E340
		// (set) Token: 0x06002A32 RID: 10802 RVA: 0x00040150 File Offset: 0x0003E350
		public unsafe bool bMeshSpaceAdditive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MakeDynamicAdditive.__PropertyOffset_bMeshSpaceAdditive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MakeDynamicAdditive.__PropertyOffset_bMeshSpaceAdditive) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x00040161 File Offset: 0x0003E361
		public FAnimNode_MakeDynamicAdditive()
		{
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x00040169 File Offset: 0x0003E369
		public FAnimNode_MakeDynamicAdditive(FPoseLink Base, FPoseLink Additive, bool bMeshSpaceAdditive)
		{
			this.Base = Base;
			this.Additive = Additive;
			this.bMeshSpaceAdditive = bMeshSpaceAdditive;
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x00040186 File Offset: 0x0003E386
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_MakeDynamicAdditive.StaticStruct();
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x00040192 File Offset: 0x0003E392
		[NullableContext(2)]
		public FAnimNode_MakeDynamicAdditive(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x0004019C File Offset: 0x0003E39C
		public FAnimNode_MakeDynamicAdditive(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000401A7 File Offset: 0x0003E3A7
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_MakeDynamicAdditive(Pointer, false, true);
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000401B1 File Offset: 0x0003E3B1
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_MakeDynamicAdditive(Pointer, MemoryOwner);
		}

		// Token: 0x0400110B RID: 4363
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive";

		// Token: 0x0400110C RID: 4364
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400110D RID: 4365
		internal static int __PropertyOffset_Base;

		// Token: 0x0400110E RID: 4366
		[Nullable(2)]
		private FPoseLink _Base;

		// Token: 0x0400110F RID: 4367
		internal static int __PropertyOffset_Additive;

		// Token: 0x04001110 RID: 4368
		[Nullable(2)]
		private FPoseLink _Additive;

		// Token: 0x04001111 RID: 4369
		internal static int __PropertyOffset_bMeshSpaceAdditive;
	}
}
