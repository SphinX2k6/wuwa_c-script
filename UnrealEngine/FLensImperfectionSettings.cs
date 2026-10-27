using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D21 RID: 3361
	[UnrealObjectPath("/Script/Engine.LensImperfectionSettings")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FLensImperfectionSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B428 RID: 46120 RVA: 0x00100E43 File Offset: 0x000FF043
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLensImperfectionSettings._ScriptStructPtr != 0) ? FLensImperfectionSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LensImperfectionSettings", ref FLensImperfectionSettings._ScriptStructPtr);
		}

		// Token: 0x1700292F RID: 10543
		// (get) Token: 0x0600B429 RID: 46121 RVA: 0x00100E67 File Offset: 0x000FF067
		// (set) Token: 0x0600B42A RID: 46122 RVA: 0x00100E7B File Offset: 0x000FF07B
		[Nullable(2)]
		public unsafe UTexture DirtMask
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FLensImperfectionSettings.__PropertyOffset_DirtMask);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLensImperfectionSettings.__PropertyOffset_DirtMask, value);
			}
		}

		// Token: 0x17002930 RID: 10544
		// (get) Token: 0x0600B42B RID: 46123 RVA: 0x00100E90 File Offset: 0x000FF090
		// (set) Token: 0x0600B42C RID: 46124 RVA: 0x00100EA0 File Offset: 0x000FF0A0
		public unsafe float DirtMaskIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensImperfectionSettings.__PropertyOffset_DirtMaskIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensImperfectionSettings.__PropertyOffset_DirtMaskIntensity) = value;
			}
		}

		// Token: 0x17002931 RID: 10545
		// (get) Token: 0x0600B42D RID: 46125 RVA: 0x00100EB1 File Offset: 0x000FF0B1
		// (set) Token: 0x0600B42E RID: 46126 RVA: 0x00100EC5 File Offset: 0x000FF0C5
		public unsafe FLinearColor DirtMaskTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensImperfectionSettings.__PropertyOffset_DirtMaskTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensImperfectionSettings.__PropertyOffset_DirtMaskTint) = value;
			}
		}

		// Token: 0x0600B42F RID: 46127 RVA: 0x00100EDA File Offset: 0x000FF0DA
		public FLensImperfectionSettings()
		{
		}

		// Token: 0x0600B430 RID: 46128 RVA: 0x00100EE2 File Offset: 0x000FF0E2
		[NullableContext(1)]
		public FLensImperfectionSettings(UTexture DirtMask, float DirtMaskIntensity, FLinearColor DirtMaskTint)
		{
			this.DirtMask = DirtMask;
			this.DirtMaskIntensity = DirtMaskIntensity;
			this.DirtMaskTint = DirtMaskTint;
		}

		// Token: 0x0600B431 RID: 46129 RVA: 0x00100EFF File Offset: 0x000FF0FF
		protected override IntPtr GetUStructPtr()
		{
			return FLensImperfectionSettings.StaticStruct();
		}

		// Token: 0x0600B432 RID: 46130 RVA: 0x00100F0B File Offset: 0x000FF10B
		[NullableContext(2)]
		public FLensImperfectionSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B433 RID: 46131 RVA: 0x00100F15 File Offset: 0x000FF115
		public FLensImperfectionSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B434 RID: 46132 RVA: 0x00100F20 File Offset: 0x000FF120
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLensImperfectionSettings(Pointer, false, true);
		}

		// Token: 0x0600B435 RID: 46133 RVA: 0x00100F2A File Offset: 0x000FF12A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLensImperfectionSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04005EAC RID: 24236
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LensImperfectionSettings";

		// Token: 0x04005EAD RID: 24237
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005EAE RID: 24238
		internal static int __PropertyOffset_DirtMask;

		// Token: 0x04005EAF RID: 24239
		internal static int __PropertyOffset_DirtMaskIntensity;

		// Token: 0x04005EB0 RID: 24240
		internal static int __PropertyOffset_DirtMaskTint;
	}
}
