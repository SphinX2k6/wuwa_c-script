using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200178C RID: 6028
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainParticleGpu")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FJacobiChainParticleGpu : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015B01 RID: 88833 RVA: 0x001FDF90 File Offset: 0x001FC190
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainParticleGpu._ScriptStructPtr != 0) ? FJacobiChainParticleGpu._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainParticleGpu", ref FJacobiChainParticleGpu._ScriptStructPtr);
		}

		// Token: 0x170055BE RID: 21950
		// (get) Token: 0x06015B02 RID: 88834 RVA: 0x001FDFB4 File Offset: 0x001FC1B4
		// (set) Token: 0x06015B03 RID: 88835 RVA: 0x001FDFC8 File Offset: 0x001FC1C8
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainParticleGpu.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainParticleGpu.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x170055BF RID: 21951
		// (get) Token: 0x06015B04 RID: 88836 RVA: 0x001FDFDD File Offset: 0x001FC1DD
		// (set) Token: 0x06015B05 RID: 88837 RVA: 0x001FDFED File Offset: 0x001FC1ED
		public unsafe float InverseMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainParticleGpu.__PropertyOffset_InverseMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainParticleGpu.__PropertyOffset_InverseMass) = value;
			}
		}

		// Token: 0x170055C0 RID: 21952
		// (get) Token: 0x06015B06 RID: 88838 RVA: 0x001FDFFE File Offset: 0x001FC1FE
		// (set) Token: 0x06015B07 RID: 88839 RVA: 0x001FE012 File Offset: 0x001FC212
		public unsafe FVector Previous
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainParticleGpu.__PropertyOffset_Previous);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainParticleGpu.__PropertyOffset_Previous) = value;
			}
		}

		// Token: 0x170055C1 RID: 21953
		// (get) Token: 0x06015B08 RID: 88840 RVA: 0x001FE027 File Offset: 0x001FC227
		// (set) Token: 0x06015B09 RID: 88841 RVA: 0x001FE037 File Offset: 0x001FC237
		public unsafe uint Flags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainParticleGpu.__PropertyOffset_Flags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainParticleGpu.__PropertyOffset_Flags) = (int)value;
			}
		}

		// Token: 0x170055C2 RID: 21954
		// (get) Token: 0x06015B0A RID: 88842 RVA: 0x001FE048 File Offset: 0x001FC248
		// (set) Token: 0x06015B0B RID: 88843 RVA: 0x001FE05C File Offset: 0x001FC25C
		public unsafe FVector RestPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainParticleGpu.__PropertyOffset_RestPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainParticleGpu.__PropertyOffset_RestPosition) = value;
			}
		}

		// Token: 0x170055C3 RID: 21955
		// (get) Token: 0x06015B0C RID: 88844 RVA: 0x001FE071 File Offset: 0x001FC271
		// (set) Token: 0x06015B0D RID: 88845 RVA: 0x001FE081 File Offset: 0x001FC281
		public unsafe float Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainParticleGpu.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainParticleGpu.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x06015B0E RID: 88846 RVA: 0x001FE092 File Offset: 0x001FC292
		public FJacobiChainParticleGpu()
		{
		}

		// Token: 0x06015B0F RID: 88847 RVA: 0x001FE09A File Offset: 0x001FC29A
		public FJacobiChainParticleGpu(FVector Position, float InverseMass, FVector Previous, uint Flags, FVector RestPosition, float Padding)
		{
			this.Position = Position;
			this.InverseMass = InverseMass;
			this.Previous = Previous;
			this.Flags = Flags;
			this.RestPosition = RestPosition;
			this.Padding = Padding;
		}

		// Token: 0x06015B10 RID: 88848 RVA: 0x001FE0CF File Offset: 0x001FC2CF
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainParticleGpu.StaticStruct();
		}

		// Token: 0x06015B11 RID: 88849 RVA: 0x001FE0DB File Offset: 0x001FC2DB
		[NullableContext(2)]
		public FJacobiChainParticleGpu(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015B12 RID: 88850 RVA: 0x001FE0E5 File Offset: 0x001FC2E5
		public FJacobiChainParticleGpu(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015B13 RID: 88851 RVA: 0x001FE0F0 File Offset: 0x001FC2F0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainParticleGpu(Pointer, false, true);
		}

		// Token: 0x06015B14 RID: 88852 RVA: 0x001FE0FA File Offset: 0x001FC2FA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainParticleGpu(Pointer, MemoryOwner);
		}

		// Token: 0x0400BD6E RID: 48494
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainParticleGpu";

		// Token: 0x0400BD6F RID: 48495
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BD70 RID: 48496
		internal static int __PropertyOffset_Position;

		// Token: 0x0400BD71 RID: 48497
		internal static int __PropertyOffset_InverseMass;

		// Token: 0x0400BD72 RID: 48498
		internal static int __PropertyOffset_Previous;

		// Token: 0x0400BD73 RID: 48499
		internal static int __PropertyOffset_Flags;

		// Token: 0x0400BD74 RID: 48500
		internal static int __PropertyOffset_RestPosition;

		// Token: 0x0400BD75 RID: 48501
		internal static int __PropertyOffset_Padding;
	}
}
