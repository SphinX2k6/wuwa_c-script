using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011F9 RID: 4601
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TouchInputControl")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FTouchInputControl : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010F69 RID: 69481 RVA: 0x0018E5D4 File Offset: 0x0018C7D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTouchInputControl._ScriptStructPtr != 0) ? FTouchInputControl._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TouchInputControl", ref FTouchInputControl._ScriptStructPtr);
		}

		// Token: 0x17004248 RID: 16968
		// (get) Token: 0x06010F6A RID: 69482 RVA: 0x0018E5F8 File Offset: 0x0018C7F8
		// (set) Token: 0x06010F6B RID: 69483 RVA: 0x0018E60C File Offset: 0x0018C80C
		[Nullable(2)]
		public unsafe UTexture2D Image1
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FTouchInputControl.__PropertyOffset_Image1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTouchInputControl.__PropertyOffset_Image1, value);
			}
		}

		// Token: 0x17004249 RID: 16969
		// (get) Token: 0x06010F6C RID: 69484 RVA: 0x0018E621 File Offset: 0x0018C821
		// (set) Token: 0x06010F6D RID: 69485 RVA: 0x0018E635 File Offset: 0x0018C835
		[Nullable(2)]
		public unsafe UTexture2D Image2
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FTouchInputControl.__PropertyOffset_Image2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTouchInputControl.__PropertyOffset_Image2, value);
			}
		}

		// Token: 0x1700424A RID: 16970
		// (get) Token: 0x06010F6E RID: 69486 RVA: 0x0018E64A File Offset: 0x0018C84A
		// (set) Token: 0x06010F6F RID: 69487 RVA: 0x0018E65E File Offset: 0x0018C85E
		public unsafe FVector2D Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTouchInputControl.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTouchInputControl.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x1700424B RID: 16971
		// (get) Token: 0x06010F70 RID: 69488 RVA: 0x0018E673 File Offset: 0x0018C873
		// (set) Token: 0x06010F71 RID: 69489 RVA: 0x0018E687 File Offset: 0x0018C887
		public unsafe FVector2D VisualSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTouchInputControl.__PropertyOffset_VisualSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTouchInputControl.__PropertyOffset_VisualSize) = value;
			}
		}

		// Token: 0x1700424C RID: 16972
		// (get) Token: 0x06010F72 RID: 69490 RVA: 0x0018E69C File Offset: 0x0018C89C
		// (set) Token: 0x06010F73 RID: 69491 RVA: 0x0018E6B0 File Offset: 0x0018C8B0
		public unsafe FVector2D ThumbSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTouchInputControl.__PropertyOffset_ThumbSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTouchInputControl.__PropertyOffset_ThumbSize) = value;
			}
		}

		// Token: 0x1700424D RID: 16973
		// (get) Token: 0x06010F74 RID: 69492 RVA: 0x0018E6C5 File Offset: 0x0018C8C5
		// (set) Token: 0x06010F75 RID: 69493 RVA: 0x0018E6D9 File Offset: 0x0018C8D9
		public unsafe FVector2D InteractionSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTouchInputControl.__PropertyOffset_InteractionSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTouchInputControl.__PropertyOffset_InteractionSize) = value;
			}
		}

		// Token: 0x1700424E RID: 16974
		// (get) Token: 0x06010F76 RID: 69494 RVA: 0x0018E6EE File Offset: 0x0018C8EE
		// (set) Token: 0x06010F77 RID: 69495 RVA: 0x0018E702 File Offset: 0x0018C902
		public unsafe FVector2D InputScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTouchInputControl.__PropertyOffset_InputScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTouchInputControl.__PropertyOffset_InputScale) = value;
			}
		}

		// Token: 0x1700424F RID: 16975
		// (get) Token: 0x06010F78 RID: 69496 RVA: 0x0018E718 File Offset: 0x0018C918
		// (set) Token: 0x06010F79 RID: 69497 RVA: 0x0018E75B File Offset: 0x0018C95B
		public FKey MainInputKey
		{
			get
			{
				base.FastCheckIsValid();
				FKey result;
				if ((result = this._MainInputKey) == null)
				{
					result = (this._MainInputKey = new FKey(base.NativePtr + (IntPtr)FTouchInputControl.__PropertyOffset_MainInputKey, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), base.NativePtr + (IntPtr)FTouchInputControl.__PropertyOffset_MainInputKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004250 RID: 16976
		// (get) Token: 0x06010F7A RID: 69498 RVA: 0x0018E77C File Offset: 0x0018C97C
		// (set) Token: 0x06010F7B RID: 69499 RVA: 0x0018E7BF File Offset: 0x0018C9BF
		public FKey AltInputKey
		{
			get
			{
				base.FastCheckIsValid();
				FKey result;
				if ((result = this._AltInputKey) == null)
				{
					result = (this._AltInputKey = new FKey(base.NativePtr + (IntPtr)FTouchInputControl.__PropertyOffset_AltInputKey, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), base.NativePtr + (IntPtr)FTouchInputControl.__PropertyOffset_AltInputKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06010F7C RID: 69500 RVA: 0x0018E7E0 File Offset: 0x0018C9E0
		public FTouchInputControl()
		{
		}

		// Token: 0x06010F7D RID: 69501 RVA: 0x0018E7E8 File Offset: 0x0018C9E8
		public FTouchInputControl(UTexture2D Image1, UTexture2D Image2, FVector2D Center, FVector2D VisualSize, FVector2D ThumbSize, FVector2D InteractionSize, FVector2D InputScale, FKey MainInputKey, FKey AltInputKey)
		{
			this.Image1 = Image1;
			this.Image2 = Image2;
			this.Center = Center;
			this.VisualSize = VisualSize;
			this.ThumbSize = ThumbSize;
			this.InteractionSize = InteractionSize;
			this.InputScale = InputScale;
			this.MainInputKey = MainInputKey;
			this.AltInputKey = AltInputKey;
		}

		// Token: 0x06010F7E RID: 69502 RVA: 0x0018E840 File Offset: 0x0018CA40
		protected override IntPtr GetUStructPtr()
		{
			return FTouchInputControl.StaticStruct();
		}

		// Token: 0x06010F7F RID: 69503 RVA: 0x0018E84C File Offset: 0x0018CA4C
		[NullableContext(2)]
		public FTouchInputControl(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010F80 RID: 69504 RVA: 0x0018E856 File Offset: 0x0018CA56
		public FTouchInputControl(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010F81 RID: 69505 RVA: 0x0018E861 File Offset: 0x0018CA61
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTouchInputControl(Pointer, false, true);
		}

		// Token: 0x06010F82 RID: 69506 RVA: 0x0018E86B File Offset: 0x0018CA6B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTouchInputControl(Pointer, MemoryOwner);
		}

		// Token: 0x0400915C RID: 37212
		public const string __ObjectPath = "/Script/Engine.TouchInputControl";

		// Token: 0x0400915D RID: 37213
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400915E RID: 37214
		internal static int __PropertyOffset_Image1;

		// Token: 0x0400915F RID: 37215
		internal static int __PropertyOffset_Image2;

		// Token: 0x04009160 RID: 37216
		internal static int __PropertyOffset_Center;

		// Token: 0x04009161 RID: 37217
		internal static int __PropertyOffset_VisualSize;

		// Token: 0x04009162 RID: 37218
		internal static int __PropertyOffset_ThumbSize;

		// Token: 0x04009163 RID: 37219
		internal static int __PropertyOffset_InteractionSize;

		// Token: 0x04009164 RID: 37220
		internal static int __PropertyOffset_InputScale;

		// Token: 0x04009165 RID: 37221
		internal static int __PropertyOffset_MainInputKey;

		// Token: 0x04009166 RID: 37222
		[Nullable(2)]
		private FKey _MainInputKey;

		// Token: 0x04009167 RID: 37223
		internal static int __PropertyOffset_AltInputKey;

		// Token: 0x04009168 RID: 37224
		[Nullable(2)]
		private FKey _AltInputKey;
	}
}
