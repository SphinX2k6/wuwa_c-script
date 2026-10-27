using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008B2 RID: 2226
	[UnrealObjectPath("/Script/Engine.BlendSample")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FBlendSample : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060079A3 RID: 31139 RVA: 0x000ADFFB File Offset: 0x000AC1FB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlendSample._ScriptStructPtr != 0) ? FBlendSample._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlendSample", ref FBlendSample._ScriptStructPtr);
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x060079A4 RID: 31140 RVA: 0x000AE01F File Offset: 0x000AC21F
		// (set) Token: 0x060079A5 RID: 31141 RVA: 0x000AE033 File Offset: 0x000AC233
		[Nullable(2)]
		public unsafe UAnimSequence Animation
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FBlendSample.__PropertyOffset_Animation);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBlendSample.__PropertyOffset_Animation, value);
			}
		}

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x060079A6 RID: 31142 RVA: 0x000AE048 File Offset: 0x000AC248
		// (set) Token: 0x060079A7 RID: 31143 RVA: 0x000AE05C File Offset: 0x000AC25C
		public unsafe FVector SampleValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendSample.__PropertyOffset_SampleValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendSample.__PropertyOffset_SampleValue) = value;
			}
		}

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x060079A8 RID: 31144 RVA: 0x000AE071 File Offset: 0x000AC271
		// (set) Token: 0x060079A9 RID: 31145 RVA: 0x000AE081 File Offset: 0x000AC281
		public unsafe float RateScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendSample.__PropertyOffset_RateScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendSample.__PropertyOffset_RateScale) = value;
			}
		}

		// Token: 0x060079AA RID: 31146 RVA: 0x000AE092 File Offset: 0x000AC292
		public FBlendSample()
		{
		}

		// Token: 0x060079AB RID: 31147 RVA: 0x000AE09A File Offset: 0x000AC29A
		[NullableContext(1)]
		public FBlendSample(UAnimSequence Animation, FVector SampleValue, float RateScale, bool bSnapToGrid, bool bIsValid)
		{
			this.Animation = Animation;
			this.SampleValue = SampleValue;
			this.RateScale = RateScale;
		}

		// Token: 0x060079AC RID: 31148 RVA: 0x000AE0B7 File Offset: 0x000AC2B7
		protected override IntPtr GetUStructPtr()
		{
			return FBlendSample.StaticStruct();
		}

		// Token: 0x060079AD RID: 31149 RVA: 0x000AE0C3 File Offset: 0x000AC2C3
		[NullableContext(2)]
		public FBlendSample(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060079AE RID: 31150 RVA: 0x000AE0CD File Offset: 0x000AC2CD
		public FBlendSample(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060079AF RID: 31151 RVA: 0x000AE0D8 File Offset: 0x000AC2D8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlendSample(Pointer, false, true);
		}

		// Token: 0x060079B0 RID: 31152 RVA: 0x000AE0E2 File Offset: 0x000AC2E2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlendSample(Pointer, MemoryOwner);
		}

		// Token: 0x04003A73 RID: 14963
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BlendSample";

		// Token: 0x04003A74 RID: 14964
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003A75 RID: 14965
		internal static int __PropertyOffset_Animation;

		// Token: 0x04003A76 RID: 14966
		internal static int __PropertyOffset_SampleValue;

		// Token: 0x04003A77 RID: 14967
		internal static int __PropertyOffset_RateScale;
	}
}
