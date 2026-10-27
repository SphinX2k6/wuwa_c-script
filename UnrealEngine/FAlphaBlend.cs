using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007D6 RID: 2006
	[UnrealObjectPath("/Script/Engine.AlphaBlend")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FAlphaBlend : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006ADD RID: 27357 RVA: 0x00099F91 File Offset: 0x00098191
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAlphaBlend._ScriptStructPtr != 0) ? FAlphaBlend._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AlphaBlend", ref FAlphaBlend._ScriptStructPtr);
		}

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06006ADE RID: 27358 RVA: 0x00099FB5 File Offset: 0x000981B5
		// (set) Token: 0x06006ADF RID: 27359 RVA: 0x00099FC9 File Offset: 0x000981C9
		[Nullable(2)]
		public unsafe UCurveFloat CustomCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAlphaBlend.__PropertyOffset_CustomCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAlphaBlend.__PropertyOffset_CustomCurve, value);
			}
		}

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x06006AE0 RID: 27360 RVA: 0x00099FDE File Offset: 0x000981DE
		// (set) Token: 0x06006AE1 RID: 27361 RVA: 0x00099FEE File Offset: 0x000981EE
		public unsafe float BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAlphaBlend.__PropertyOffset_BlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAlphaBlend.__PropertyOffset_BlendTime) = value;
			}
		}

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x06006AE2 RID: 27362 RVA: 0x00099FFF File Offset: 0x000981FF
		// (set) Token: 0x06006AE3 RID: 27363 RVA: 0x0009A00F File Offset: 0x0009820F
		public unsafe EAlphaBlendOption BlendOption
		{
			get
			{
				return (EAlphaBlendOption)(*(base.NativePtr + (IntPtr)FAlphaBlend.__PropertyOffset_BlendOption));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAlphaBlend.__PropertyOffset_BlendOption) = (byte)value;
			}
		}

		// Token: 0x06006AE4 RID: 27364 RVA: 0x0009A020 File Offset: 0x00098220
		public FAlphaBlend()
		{
		}

		// Token: 0x06006AE5 RID: 27365 RVA: 0x0009A028 File Offset: 0x00098228
		[NullableContext(1)]
		public FAlphaBlend(UCurveFloat CustomCurve, float BlendTime, EAlphaBlendOption BlendOption)
		{
			this.CustomCurve = CustomCurve;
			this.BlendTime = BlendTime;
			this.BlendOption = BlendOption;
		}

		// Token: 0x06006AE6 RID: 27366 RVA: 0x0009A045 File Offset: 0x00098245
		protected override IntPtr GetUStructPtr()
		{
			return FAlphaBlend.StaticStruct();
		}

		// Token: 0x06006AE7 RID: 27367 RVA: 0x0009A051 File Offset: 0x00098251
		[NullableContext(2)]
		public FAlphaBlend(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006AE8 RID: 27368 RVA: 0x0009A05B File Offset: 0x0009825B
		public FAlphaBlend(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x0009A066 File Offset: 0x00098266
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAlphaBlend(Pointer, false, true);
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x0009A070 File Offset: 0x00098270
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAlphaBlend(Pointer, MemoryOwner);
		}

		// Token: 0x04003371 RID: 13169
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AlphaBlend";

		// Token: 0x04003372 RID: 13170
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003373 RID: 13171
		internal static int __PropertyOffset_CustomCurve;

		// Token: 0x04003374 RID: 13172
		internal static int __PropertyOffset_BlendTime;

		// Token: 0x04003375 RID: 13173
		internal static int __PropertyOffset_BlendOption;
	}
}
