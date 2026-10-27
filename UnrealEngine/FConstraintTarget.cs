using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B6 RID: 1206
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ConstraintTarget")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FConstraintTarget : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004036 RID: 16438 RVA: 0x00060866 File Offset: 0x0005EA66
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConstraintTarget._ScriptStructPtr != 0) ? FConstraintTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ConstraintTarget", ref FConstraintTarget._ScriptStructPtr);
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06004037 RID: 16439 RVA: 0x0006088A File Offset: 0x0005EA8A
		// (set) Token: 0x06004038 RID: 16440 RVA: 0x0006089E File Offset: 0x0005EA9E
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintTarget.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintTarget.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06004039 RID: 16441 RVA: 0x000608B3 File Offset: 0x0005EAB3
		// (set) Token: 0x0600403A RID: 16442 RVA: 0x000608C3 File Offset: 0x0005EAC3
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintTarget.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintTarget.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x0600403B RID: 16443 RVA: 0x000608D4 File Offset: 0x0005EAD4
		// (set) Token: 0x0600403C RID: 16444 RVA: 0x000608E4 File Offset: 0x0005EAE4
		public unsafe bool bMaintainOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintTarget.__PropertyOffset_bMaintainOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintTarget.__PropertyOffset_bMaintainOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x0600403D RID: 16445 RVA: 0x000608F8 File Offset: 0x0005EAF8
		// (set) Token: 0x0600403E RID: 16446 RVA: 0x0006093B File Offset: 0x0005EB3B
		public FTransformFilter Filter
		{
			get
			{
				base.FastCheckIsValid();
				FTransformFilter result;
				if ((result = this._Filter) == null)
				{
					result = (this._Filter = new FTransformFilter(base.NativePtr + (IntPtr)FConstraintTarget.__PropertyOffset_Filter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTransformFilter.StaticStruct(), base.NativePtr + (IntPtr)FConstraintTarget.__PropertyOffset_Filter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x0006095C File Offset: 0x0005EB5C
		public FConstraintTarget()
		{
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x00060964 File Offset: 0x0005EB64
		public FConstraintTarget(FTransform Transform, float Weight, bool bMaintainOffset, FTransformFilter Filter)
		{
			this.Transform = Transform;
			this.Weight = Weight;
			this.bMaintainOffset = bMaintainOffset;
			this.Filter = Filter;
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x00060989 File Offset: 0x0005EB89
		protected override IntPtr GetUStructPtr()
		{
			return FConstraintTarget.StaticStruct();
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x00060995 File Offset: 0x0005EB95
		[NullableContext(2)]
		public FConstraintTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x0006099F File Offset: 0x0005EB9F
		public FConstraintTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x000609AA File Offset: 0x0005EBAA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConstraintTarget(Pointer, false, true);
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x000609B4 File Offset: 0x0005EBB4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConstraintTarget(Pointer, MemoryOwner);
		}

		// Token: 0x04001EB4 RID: 7860
		public const string __ObjectPath = "/Script/ControlRig.ConstraintTarget";

		// Token: 0x04001EB5 RID: 7861
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001EB6 RID: 7862
		internal static int __PropertyOffset_Transform;

		// Token: 0x04001EB7 RID: 7863
		internal static int __PropertyOffset_Weight;

		// Token: 0x04001EB8 RID: 7864
		internal static int __PropertyOffset_bMaintainOffset;

		// Token: 0x04001EB9 RID: 7865
		internal static int __PropertyOffset_Filter;

		// Token: 0x04001EBA RID: 7866
		[Nullable(2)]
		private FTransformFilter _Filter;
	}
}
