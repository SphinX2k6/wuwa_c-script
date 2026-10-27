using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002116 RID: 8470
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.ToggleStateAnimation")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FToggleStateAnimation : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FDEC RID: 130540 RVA: 0x002F6A1C File Offset: 0x002F4C1C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FToggleStateAnimation._ScriptStructPtr != 0) ? FToggleStateAnimation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.ToggleStateAnimation", ref FToggleStateAnimation._ScriptStructPtr);
		}

		// Token: 0x17007D5A RID: 32090
		// (get) Token: 0x0601FDED RID: 130541 RVA: 0x002F6A40 File Offset: 0x002F4C40
		// (set) Token: 0x0601FDEE RID: 130542 RVA: 0x002F6A83 File Offset: 0x002F4C83
		public TMap<EToggleStateInAnimation, FToggleAnimationPlayInfo> StateToAnimation
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EToggleStateInAnimation, FToggleAnimationPlayInfo> result;
				if ((result = this._StateToAnimation) == null)
				{
					result = (this._StateToAnimation = new TMap<EToggleStateInAnimation, FToggleAnimationPlayInfo>(base.NativePtr + (IntPtr)FToggleStateAnimation.__PropertyOffset_StateToAnimation, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StateToAnimation.CopyAssign(value);
			}
		}

		// Token: 0x17007D5B RID: 32091
		// (get) Token: 0x0601FDEF RID: 130543 RVA: 0x002F6A91 File Offset: 0x002F4C91
		// (set) Token: 0x0601FDF0 RID: 130544 RVA: 0x002F6AA1 File Offset: 0x002F4CA1
		public unsafe bool bDifferSelectedState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FToggleStateAnimation.__PropertyOffset_bDifferSelectedState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FToggleStateAnimation.__PropertyOffset_bDifferSelectedState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007D5C RID: 32092
		// (get) Token: 0x0601FDF1 RID: 130545 RVA: 0x002F6AB4 File Offset: 0x002F4CB4
		// (set) Token: 0x0601FDF2 RID: 130546 RVA: 0x002F6AF7 File Offset: 0x002F4CF7
		public FToggleAnimationPlayInfo UniAnimation
		{
			get
			{
				base.FastCheckIsValid();
				FToggleAnimationPlayInfo result;
				if ((result = this._UniAnimation) == null)
				{
					result = (this._UniAnimation = new FToggleAnimationPlayInfo(base.NativePtr + (IntPtr)FToggleStateAnimation.__PropertyOffset_UniAnimation, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FToggleAnimationPlayInfo.StaticStruct(), base.NativePtr + (IntPtr)FToggleStateAnimation.__PropertyOffset_UniAnimation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601FDF3 RID: 130547 RVA: 0x002F6B18 File Offset: 0x002F4D18
		public FToggleStateAnimation()
		{
		}

		// Token: 0x0601FDF4 RID: 130548 RVA: 0x002F6B20 File Offset: 0x002F4D20
		public FToggleStateAnimation(TMap<EToggleStateInAnimation, FToggleAnimationPlayInfo> StateToAnimation, bool bDifferSelectedState, FToggleAnimationPlayInfo UniAnimation)
		{
			this.StateToAnimation = StateToAnimation;
			this.bDifferSelectedState = bDifferSelectedState;
			this.UniAnimation = UniAnimation;
		}

		// Token: 0x0601FDF5 RID: 130549 RVA: 0x002F6B3D File Offset: 0x002F4D3D
		protected override IntPtr GetUStructPtr()
		{
			return FToggleStateAnimation.StaticStruct();
		}

		// Token: 0x0601FDF6 RID: 130550 RVA: 0x002F6B49 File Offset: 0x002F4D49
		[NullableContext(2)]
		public FToggleStateAnimation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FDF7 RID: 130551 RVA: 0x002F6B53 File Offset: 0x002F4D53
		public FToggleStateAnimation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FDF8 RID: 130552 RVA: 0x002F6B5E File Offset: 0x002F4D5E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FToggleStateAnimation(Pointer, false, true);
		}

		// Token: 0x0601FDF9 RID: 130553 RVA: 0x002F6B68 File Offset: 0x002F4D68
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FToggleStateAnimation(Pointer, MemoryOwner);
		}

		// Token: 0x040112CB RID: 70347
		public const string __ObjectPath = "/Script/LGUI.ToggleStateAnimation";

		// Token: 0x040112CC RID: 70348
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040112CD RID: 70349
		internal static int __PropertyOffset_StateToAnimation;

		// Token: 0x040112CE RID: 70350
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EToggleStateInAnimation, FToggleAnimationPlayInfo> _StateToAnimation;

		// Token: 0x040112CF RID: 70351
		internal static int __PropertyOffset_bDifferSelectedState;

		// Token: 0x040112D0 RID: 70352
		internal static int __PropertyOffset_UniAnimation;

		// Token: 0x040112D1 RID: 70353
		[Nullable(2)]
		private FToggleAnimationPlayInfo _UniAnimation;
	}
}
