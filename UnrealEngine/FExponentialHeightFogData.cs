using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BC7 RID: 3015
	[UnrealObjectPath("/Script/Engine.ExponentialHeightFogData")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FExponentialHeightFogData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009429 RID: 37929 RVA: 0x000D391A File Offset: 0x000D1B1A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExponentialHeightFogData._ScriptStructPtr != 0) ? FExponentialHeightFogData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ExponentialHeightFogData", ref FExponentialHeightFogData._ScriptStructPtr);
		}

		// Token: 0x1700237B RID: 9083
		// (get) Token: 0x0600942A RID: 37930 RVA: 0x000D393E File Offset: 0x000D1B3E
		// (set) Token: 0x0600942B RID: 37931 RVA: 0x000D394E File Offset: 0x000D1B4E
		public unsafe float FogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExponentialHeightFogData.__PropertyOffset_FogDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExponentialHeightFogData.__PropertyOffset_FogDensity) = value;
			}
		}

		// Token: 0x1700237C RID: 9084
		// (get) Token: 0x0600942C RID: 37932 RVA: 0x000D395F File Offset: 0x000D1B5F
		// (set) Token: 0x0600942D RID: 37933 RVA: 0x000D396F File Offset: 0x000D1B6F
		public unsafe float FogHeightFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExponentialHeightFogData.__PropertyOffset_FogHeightFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExponentialHeightFogData.__PropertyOffset_FogHeightFalloff) = value;
			}
		}

		// Token: 0x1700237D RID: 9085
		// (get) Token: 0x0600942E RID: 37934 RVA: 0x000D3980 File Offset: 0x000D1B80
		// (set) Token: 0x0600942F RID: 37935 RVA: 0x000D3990 File Offset: 0x000D1B90
		public unsafe float FogHeightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExponentialHeightFogData.__PropertyOffset_FogHeightOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExponentialHeightFogData.__PropertyOffset_FogHeightOffset) = value;
			}
		}

		// Token: 0x06009430 RID: 37936 RVA: 0x000D39A1 File Offset: 0x000D1BA1
		public FExponentialHeightFogData()
		{
		}

		// Token: 0x06009431 RID: 37937 RVA: 0x000D39A9 File Offset: 0x000D1BA9
		public FExponentialHeightFogData(float FogDensity, float FogHeightFalloff, float FogHeightOffset)
		{
			this.FogDensity = FogDensity;
			this.FogHeightFalloff = FogHeightFalloff;
			this.FogHeightOffset = FogHeightOffset;
		}

		// Token: 0x06009432 RID: 37938 RVA: 0x000D39C6 File Offset: 0x000D1BC6
		protected override IntPtr GetUStructPtr()
		{
			return FExponentialHeightFogData.StaticStruct();
		}

		// Token: 0x06009433 RID: 37939 RVA: 0x000D39D2 File Offset: 0x000D1BD2
		[NullableContext(2)]
		public FExponentialHeightFogData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009434 RID: 37940 RVA: 0x000D39DC File Offset: 0x000D1BDC
		public FExponentialHeightFogData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009435 RID: 37941 RVA: 0x000D39E7 File Offset: 0x000D1BE7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExponentialHeightFogData(Pointer, false, true);
		}

		// Token: 0x06009436 RID: 37942 RVA: 0x000D39F1 File Offset: 0x000D1BF1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExponentialHeightFogData(Pointer, MemoryOwner);
		}

		// Token: 0x04005349 RID: 21321
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ExponentialHeightFogData";

		// Token: 0x0400534A RID: 21322
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400534B RID: 21323
		internal static int __PropertyOffset_FogDensity;

		// Token: 0x0400534C RID: 21324
		internal static int __PropertyOffset_FogHeightFalloff;

		// Token: 0x0400534D RID: 21325
		internal static int __PropertyOffset_FogHeightOffset;
	}
}
