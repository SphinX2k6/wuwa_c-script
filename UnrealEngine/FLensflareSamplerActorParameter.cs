using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BF9 RID: 7161
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.LensflareSamplerActorParameter")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FLensflareSamplerActorParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B9E1 RID: 113121 RVA: 0x0028A3E4 File Offset: 0x002885E4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLensflareSamplerActorParameter._ScriptStructPtr != 0) ? FLensflareSamplerActorParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.LensflareSamplerActorParameter", ref FLensflareSamplerActorParameter._ScriptStructPtr);
		}

		// Token: 0x17006F50 RID: 28496
		// (get) Token: 0x0601B9E2 RID: 113122 RVA: 0x0028A408 File Offset: 0x00288608
		// (set) Token: 0x0601B9E3 RID: 113123 RVA: 0x0028A418 File Offset: 0x00288618
		public unsafe float Falloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorParameter.__PropertyOffset_Falloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorParameter.__PropertyOffset_Falloff) = value;
			}
		}

		// Token: 0x17006F51 RID: 28497
		// (get) Token: 0x0601B9E4 RID: 113124 RVA: 0x0028A429 File Offset: 0x00288629
		// (set) Token: 0x0601B9E5 RID: 113125 RVA: 0x0028A439 File Offset: 0x00288639
		public unsafe float ScreenSizeCullRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensflareSamplerActorParameter.__PropertyOffset_ScreenSizeCullRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensflareSamplerActorParameter.__PropertyOffset_ScreenSizeCullRatio) = value;
			}
		}

		// Token: 0x0601B9E6 RID: 113126 RVA: 0x0028A44A File Offset: 0x0028864A
		public FLensflareSamplerActorParameter()
		{
		}

		// Token: 0x0601B9E7 RID: 113127 RVA: 0x0028A452 File Offset: 0x00288652
		public FLensflareSamplerActorParameter(float Falloff, float ScreenSizeCullRatio)
		{
			this.Falloff = Falloff;
			this.ScreenSizeCullRatio = ScreenSizeCullRatio;
		}

		// Token: 0x0601B9E8 RID: 113128 RVA: 0x0028A468 File Offset: 0x00288668
		protected override IntPtr GetUStructPtr()
		{
			return FLensflareSamplerActorParameter.StaticStruct();
		}

		// Token: 0x0601B9E9 RID: 113129 RVA: 0x0028A474 File Offset: 0x00288674
		[NullableContext(2)]
		public FLensflareSamplerActorParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B9EA RID: 113130 RVA: 0x0028A47E File Offset: 0x0028867E
		public FLensflareSamplerActorParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B9EB RID: 113131 RVA: 0x0028A489 File Offset: 0x00288689
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLensflareSamplerActorParameter(Pointer, false, true);
		}

		// Token: 0x0601B9EC RID: 113132 RVA: 0x0028A493 File Offset: 0x00288693
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLensflareSamplerActorParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0400ED98 RID: 60824
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.LensflareSamplerActorParameter";

		// Token: 0x0400ED99 RID: 60825
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400ED9A RID: 60826
		internal static int __PropertyOffset_Falloff;

		// Token: 0x0400ED9B RID: 60827
		internal static int __PropertyOffset_ScreenSizeCullRatio;
	}
}
