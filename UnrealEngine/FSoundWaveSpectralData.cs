using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200115E RID: 4446
	[UnrealObjectPath("/Script/Engine.SoundWaveSpectralData")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FSoundWaveSpectralData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010403 RID: 66563 RVA: 0x0017F14E File Offset: 0x0017D34E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundWaveSpectralData._ScriptStructPtr != 0) ? FSoundWaveSpectralData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundWaveSpectralData", ref FSoundWaveSpectralData._ScriptStructPtr);
		}

		// Token: 0x17003FB0 RID: 16304
		// (get) Token: 0x06010404 RID: 66564 RVA: 0x0017F172 File Offset: 0x0017D372
		// (set) Token: 0x06010405 RID: 66565 RVA: 0x0017F182 File Offset: 0x0017D382
		public unsafe float FrequencyHz
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundWaveSpectralData.__PropertyOffset_FrequencyHz);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundWaveSpectralData.__PropertyOffset_FrequencyHz) = value;
			}
		}

		// Token: 0x17003FB1 RID: 16305
		// (get) Token: 0x06010406 RID: 66566 RVA: 0x0017F193 File Offset: 0x0017D393
		// (set) Token: 0x06010407 RID: 66567 RVA: 0x0017F1A3 File Offset: 0x0017D3A3
		public unsafe float Magnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundWaveSpectralData.__PropertyOffset_Magnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundWaveSpectralData.__PropertyOffset_Magnitude) = value;
			}
		}

		// Token: 0x17003FB2 RID: 16306
		// (get) Token: 0x06010408 RID: 66568 RVA: 0x0017F1B4 File Offset: 0x0017D3B4
		// (set) Token: 0x06010409 RID: 66569 RVA: 0x0017F1C4 File Offset: 0x0017D3C4
		public unsafe float NormalizedMagnitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundWaveSpectralData.__PropertyOffset_NormalizedMagnitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundWaveSpectralData.__PropertyOffset_NormalizedMagnitude) = value;
			}
		}

		// Token: 0x0601040A RID: 66570 RVA: 0x0017F1D5 File Offset: 0x0017D3D5
		public FSoundWaveSpectralData()
		{
		}

		// Token: 0x0601040B RID: 66571 RVA: 0x0017F1DD File Offset: 0x0017D3DD
		public FSoundWaveSpectralData(float FrequencyHz, float Magnitude, float NormalizedMagnitude)
		{
			this.FrequencyHz = FrequencyHz;
			this.Magnitude = Magnitude;
			this.NormalizedMagnitude = NormalizedMagnitude;
		}

		// Token: 0x0601040C RID: 66572 RVA: 0x0017F1FA File Offset: 0x0017D3FA
		protected override IntPtr GetUStructPtr()
		{
			return FSoundWaveSpectralData.StaticStruct();
		}

		// Token: 0x0601040D RID: 66573 RVA: 0x0017F206 File Offset: 0x0017D406
		[NullableContext(2)]
		public FSoundWaveSpectralData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601040E RID: 66574 RVA: 0x0017F210 File Offset: 0x0017D410
		public FSoundWaveSpectralData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601040F RID: 66575 RVA: 0x0017F21B File Offset: 0x0017D41B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundWaveSpectralData(Pointer, false, true);
		}

		// Token: 0x06010410 RID: 66576 RVA: 0x0017F225 File Offset: 0x0017D425
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundWaveSpectralData(Pointer, MemoryOwner);
		}

		// Token: 0x04008BE5 RID: 35813
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SoundWaveSpectralData";

		// Token: 0x04008BE6 RID: 35814
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008BE7 RID: 35815
		internal static int __PropertyOffset_FrequencyHz;

		// Token: 0x04008BE8 RID: 35816
		internal static int __PropertyOffset_Magnitude;

		// Token: 0x04008BE9 RID: 35817
		internal static int __PropertyOffset_NormalizedMagnitude;
	}
}
