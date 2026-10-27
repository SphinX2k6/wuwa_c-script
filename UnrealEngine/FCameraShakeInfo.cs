using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000913 RID: 2323
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CameraShakeInfo")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FCameraShakeInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007FD8 RID: 32728 RVA: 0x000B7359 File Offset: 0x000B5559
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraShakeInfo._ScriptStructPtr != 0) ? FCameraShakeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CameraShakeInfo", ref FCameraShakeInfo._ScriptStructPtr);
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x06007FD9 RID: 32729 RVA: 0x000B7380 File Offset: 0x000B5580
		// (set) Token: 0x06007FDA RID: 32730 RVA: 0x000B73C3 File Offset: 0x000B55C3
		public FCameraShakeDuration Duration
		{
			get
			{
				base.FastCheckIsValid();
				FCameraShakeDuration result;
				if ((result = this._Duration) == null)
				{
					result = (this._Duration = new FCameraShakeDuration(base.NativePtr + (IntPtr)FCameraShakeInfo.__PropertyOffset_Duration, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraShakeDuration.StaticStruct(), base.NativePtr + (IntPtr)FCameraShakeInfo.__PropertyOffset_Duration, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x06007FDB RID: 32731 RVA: 0x000B73E4 File Offset: 0x000B55E4
		// (set) Token: 0x06007FDC RID: 32732 RVA: 0x000B73F4 File Offset: 0x000B55F4
		public unsafe float BlendIn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraShakeInfo.__PropertyOffset_BlendIn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraShakeInfo.__PropertyOffset_BlendIn) = value;
			}
		}

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x06007FDD RID: 32733 RVA: 0x000B7405 File Offset: 0x000B5605
		// (set) Token: 0x06007FDE RID: 32734 RVA: 0x000B7415 File Offset: 0x000B5615
		public unsafe float BlendOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraShakeInfo.__PropertyOffset_BlendOut);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraShakeInfo.__PropertyOffset_BlendOut) = value;
			}
		}

		// Token: 0x06007FDF RID: 32735 RVA: 0x000B7426 File Offset: 0x000B5626
		public FCameraShakeInfo()
		{
		}

		// Token: 0x06007FE0 RID: 32736 RVA: 0x000B742E File Offset: 0x000B562E
		public FCameraShakeInfo(FCameraShakeDuration Duration, float BlendIn, float BlendOut)
		{
			this.Duration = Duration;
			this.BlendIn = BlendIn;
			this.BlendOut = BlendOut;
		}

		// Token: 0x06007FE1 RID: 32737 RVA: 0x000B744B File Offset: 0x000B564B
		protected override IntPtr GetUStructPtr()
		{
			return FCameraShakeInfo.StaticStruct();
		}

		// Token: 0x06007FE2 RID: 32738 RVA: 0x000B7457 File Offset: 0x000B5657
		[NullableContext(2)]
		public FCameraShakeInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007FE3 RID: 32739 RVA: 0x000B7461 File Offset: 0x000B5661
		public FCameraShakeInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007FE4 RID: 32740 RVA: 0x000B746C File Offset: 0x000B566C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraShakeInfo(Pointer, false, true);
		}

		// Token: 0x06007FE5 RID: 32741 RVA: 0x000B7476 File Offset: 0x000B5676
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraShakeInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003D49 RID: 15689
		public const string __ObjectPath = "/Script/Engine.CameraShakeInfo";

		// Token: 0x04003D4A RID: 15690
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003D4B RID: 15691
		internal static int __PropertyOffset_Duration;

		// Token: 0x04003D4C RID: 15692
		[Nullable(2)]
		private FCameraShakeDuration _Duration;

		// Token: 0x04003D4D RID: 15693
		internal static int __PropertyOffset_BlendIn;

		// Token: 0x04003D4E RID: 15694
		internal static int __PropertyOffset_BlendOut;
	}
}
