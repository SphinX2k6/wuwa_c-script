using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200105C RID: 4188
	[UnrealObjectPath("/Script/Engine.QuartzQuantizationBoundary")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FQuartzQuantizationBoundary : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EE35 RID: 60981 RVA: 0x00161780 File Offset: 0x0015F980
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQuartzQuantizationBoundary._ScriptStructPtr != 0) ? FQuartzQuantizationBoundary._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.QuartzQuantizationBoundary", ref FQuartzQuantizationBoundary._ScriptStructPtr);
		}

		// Token: 0x170039A5 RID: 14757
		// (get) Token: 0x0600EE36 RID: 60982 RVA: 0x001617A4 File Offset: 0x0015F9A4
		// (set) Token: 0x0600EE37 RID: 60983 RVA: 0x001617B4 File Offset: 0x0015F9B4
		public unsafe EQuartzCommandQuantization Quantization
		{
			get
			{
				return (EQuartzCommandQuantization)(*(base.NativePtr + (IntPtr)FQuartzQuantizationBoundary.__PropertyOffset_Quantization));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQuartzQuantizationBoundary.__PropertyOffset_Quantization) = (byte)value;
			}
		}

		// Token: 0x170039A6 RID: 14758
		// (get) Token: 0x0600EE38 RID: 60984 RVA: 0x001617C5 File Offset: 0x0015F9C5
		// (set) Token: 0x0600EE39 RID: 60985 RVA: 0x001617D5 File Offset: 0x0015F9D5
		public unsafe float Multiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQuartzQuantizationBoundary.__PropertyOffset_Multiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQuartzQuantizationBoundary.__PropertyOffset_Multiplier) = value;
			}
		}

		// Token: 0x170039A7 RID: 14759
		// (get) Token: 0x0600EE3A RID: 60986 RVA: 0x001617E6 File Offset: 0x0015F9E6
		// (set) Token: 0x0600EE3B RID: 60987 RVA: 0x001617F6 File Offset: 0x0015F9F6
		public unsafe EQuarztQuantizationReference CountingReferencePoint
		{
			get
			{
				return (EQuarztQuantizationReference)(*(base.NativePtr + (IntPtr)FQuartzQuantizationBoundary.__PropertyOffset_CountingReferencePoint));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQuartzQuantizationBoundary.__PropertyOffset_CountingReferencePoint) = (byte)value;
			}
		}

		// Token: 0x0600EE3C RID: 60988 RVA: 0x00161807 File Offset: 0x0015FA07
		public FQuartzQuantizationBoundary()
		{
		}

		// Token: 0x0600EE3D RID: 60989 RVA: 0x0016180F File Offset: 0x0015FA0F
		public FQuartzQuantizationBoundary(EQuartzCommandQuantization Quantization, float Multiplier, EQuarztQuantizationReference CountingReferencePoint)
		{
			this.Quantization = Quantization;
			this.Multiplier = Multiplier;
			this.CountingReferencePoint = CountingReferencePoint;
		}

		// Token: 0x0600EE3E RID: 60990 RVA: 0x0016182C File Offset: 0x0015FA2C
		protected override IntPtr GetUStructPtr()
		{
			return FQuartzQuantizationBoundary.StaticStruct();
		}

		// Token: 0x0600EE3F RID: 60991 RVA: 0x00161838 File Offset: 0x0015FA38
		[NullableContext(2)]
		public FQuartzQuantizationBoundary(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EE40 RID: 60992 RVA: 0x00161842 File Offset: 0x0015FA42
		public FQuartzQuantizationBoundary(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EE41 RID: 60993 RVA: 0x0016184D File Offset: 0x0015FA4D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FQuartzQuantizationBoundary(Pointer, false, true);
		}

		// Token: 0x0600EE42 RID: 60994 RVA: 0x00161857 File Offset: 0x0015FA57
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FQuartzQuantizationBoundary(Pointer, MemoryOwner);
		}

		// Token: 0x040080F9 RID: 33017
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.QuartzQuantizationBoundary";

		// Token: 0x040080FA RID: 33018
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040080FB RID: 33019
		internal static int __PropertyOffset_Quantization;

		// Token: 0x040080FC RID: 33020
		internal static int __PropertyOffset_Multiplier;

		// Token: 0x040080FD RID: 33021
		internal static int __PropertyOffset_CountingReferencePoint;
	}
}
