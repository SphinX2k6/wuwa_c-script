using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002E0 RID: 736
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_CurveSource")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FAnimNode_CurveSource : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060029A4 RID: 10660 RVA: 0x0003F00F File Offset: 0x0003D20F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_CurveSource._ScriptStructPtr != 0) ? FAnimNode_CurveSource._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_CurveSource", ref FAnimNode_CurveSource._ScriptStructPtr);
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x060029A5 RID: 10661 RVA: 0x0003F034 File Offset: 0x0003D234
		// (set) Token: 0x060029A6 RID: 10662 RVA: 0x0003F077 File Offset: 0x0003D277
		public FPoseLink SourcePose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._SourcePose) == null)
				{
					result = (this._SourcePose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_CurveSource.__PropertyOffset_SourcePose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_CurveSource.__PropertyOffset_SourcePose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x060029A7 RID: 10663 RVA: 0x0003F098 File Offset: 0x0003D298
		// (set) Token: 0x060029A8 RID: 10664 RVA: 0x0003F0AC File Offset: 0x0003D2AC
		public unsafe FName SourceBinding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveSource.__PropertyOffset_SourceBinding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveSource.__PropertyOffset_SourceBinding) = value;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x060029A9 RID: 10665 RVA: 0x0003F0C1 File Offset: 0x0003D2C1
		// (set) Token: 0x060029AA RID: 10666 RVA: 0x0003F0D1 File Offset: 0x0003D2D1
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CurveSource.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveSource.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x060029AB RID: 10667 RVA: 0x0003F0E2 File Offset: 0x0003D2E2
		// (set) Token: 0x060029AC RID: 10668 RVA: 0x0003F0FC File Offset: 0x0003D2FC
		[Nullable(2)]
		public unsafe ICurveSourceInterface CurveSource
		{
			[NullableContext(2)]
			get
			{
				return (ICurveSourceInterface)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)FAnimNode_CurveSource.__PropertyOffset_CurveSource));
			}
			[NullableContext(2)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CurveSource.__PropertyOffset_CurveSource) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x0003F122 File Offset: 0x0003D322
		public FAnimNode_CurveSource()
		{
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x0003F12A File Offset: 0x0003D32A
		public FAnimNode_CurveSource(FPoseLink SourcePose, FName SourceBinding, float Alpha, ICurveSourceInterface CurveSource)
		{
			this.SourcePose = SourcePose;
			this.SourceBinding = SourceBinding;
			this.Alpha = Alpha;
			this.CurveSource = CurveSource;
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x0003F14F File Offset: 0x0003D34F
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_CurveSource.StaticStruct();
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x0003F15B File Offset: 0x0003D35B
		[NullableContext(2)]
		public FAnimNode_CurveSource(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x0003F165 File Offset: 0x0003D365
		public FAnimNode_CurveSource(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x0003F170 File Offset: 0x0003D370
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_CurveSource(Pointer, false, true);
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x0003F17A File Offset: 0x0003D37A
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_CurveSource(Pointer, MemoryOwner);
		}

		// Token: 0x040010C0 RID: 4288
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_CurveSource";

		// Token: 0x040010C1 RID: 4289
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040010C2 RID: 4290
		internal static int __PropertyOffset_SourcePose;

		// Token: 0x040010C3 RID: 4291
		[Nullable(2)]
		private FPoseLink _SourcePose;

		// Token: 0x040010C4 RID: 4292
		internal static int __PropertyOffset_SourceBinding;

		// Token: 0x040010C5 RID: 4293
		internal static int __PropertyOffset_Alpha;

		// Token: 0x040010C6 RID: 4294
		internal static int __PropertyOffset_CurveSource;
	}
}
