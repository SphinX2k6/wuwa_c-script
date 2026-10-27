using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BCC RID: 3020
	[UnrealObjectPath("/Script/Engine.ExposureSettings")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FExposureSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009478 RID: 38008 RVA: 0x000D3F64 File Offset: 0x000D2164
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExposureSettings._ScriptStructPtr != 0) ? FExposureSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ExposureSettings", ref FExposureSettings._ScriptStructPtr);
		}

		// Token: 0x1700238E RID: 9102
		// (get) Token: 0x06009479 RID: 38009 RVA: 0x000D3F88 File Offset: 0x000D2188
		// (set) Token: 0x0600947A RID: 38010 RVA: 0x000D3F98 File Offset: 0x000D2198
		public unsafe float FixedEV100
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExposureSettings.__PropertyOffset_FixedEV100);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExposureSettings.__PropertyOffset_FixedEV100) = value;
			}
		}

		// Token: 0x1700238F RID: 9103
		// (get) Token: 0x0600947B RID: 38011 RVA: 0x000D3FA9 File Offset: 0x000D21A9
		// (set) Token: 0x0600947C RID: 38012 RVA: 0x000D3FB9 File Offset: 0x000D21B9
		public unsafe bool bFixed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExposureSettings.__PropertyOffset_bFixed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExposureSettings.__PropertyOffset_bFixed) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600947D RID: 38013 RVA: 0x000D3FCA File Offset: 0x000D21CA
		public FExposureSettings()
		{
		}

		// Token: 0x0600947E RID: 38014 RVA: 0x000D3FD2 File Offset: 0x000D21D2
		public FExposureSettings(float FixedEV100, bool bFixed)
		{
			this.FixedEV100 = FixedEV100;
			this.bFixed = bFixed;
		}

		// Token: 0x0600947F RID: 38015 RVA: 0x000D3FE8 File Offset: 0x000D21E8
		protected override IntPtr GetUStructPtr()
		{
			return FExposureSettings.StaticStruct();
		}

		// Token: 0x06009480 RID: 38016 RVA: 0x000D3FF4 File Offset: 0x000D21F4
		[NullableContext(2)]
		public FExposureSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009481 RID: 38017 RVA: 0x000D3FFE File Offset: 0x000D21FE
		public FExposureSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009482 RID: 38018 RVA: 0x000D4009 File Offset: 0x000D2209
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExposureSettings(Pointer, false, true);
		}

		// Token: 0x06009483 RID: 38019 RVA: 0x000D4013 File Offset: 0x000D2213
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExposureSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400536E RID: 21358
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ExposureSettings";

		// Token: 0x0400536F RID: 21359
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005370 RID: 21360
		internal static int __PropertyOffset_FixedEV100;

		// Token: 0x04005371 RID: 21361
		internal static int __PropertyOffset_bFixed;
	}
}
