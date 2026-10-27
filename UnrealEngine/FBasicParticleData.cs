using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024D4 RID: 9428
	[UnrealObjectPath("/Script/Niagara.BasicParticleData")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FBasicParticleData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060233F9 RID: 144377 RVA: 0x0034229C File Offset: 0x0034049C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBasicParticleData._ScriptStructPtr != 0) ? FBasicParticleData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.BasicParticleData", ref FBasicParticleData._ScriptStructPtr);
		}

		// Token: 0x17008784 RID: 34692
		// (get) Token: 0x060233FA RID: 144378 RVA: 0x003422C0 File Offset: 0x003404C0
		// (set) Token: 0x060233FB RID: 144379 RVA: 0x003422D4 File Offset: 0x003404D4
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasicParticleData.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasicParticleData.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17008785 RID: 34693
		// (get) Token: 0x060233FC RID: 144380 RVA: 0x003422E9 File Offset: 0x003404E9
		// (set) Token: 0x060233FD RID: 144381 RVA: 0x003422F9 File Offset: 0x003404F9
		public unsafe float Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasicParticleData.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasicParticleData.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x17008786 RID: 34694
		// (get) Token: 0x060233FE RID: 144382 RVA: 0x0034230A File Offset: 0x0034050A
		// (set) Token: 0x060233FF RID: 144383 RVA: 0x0034231E File Offset: 0x0034051E
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBasicParticleData.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBasicParticleData.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x06023400 RID: 144384 RVA: 0x00342333 File Offset: 0x00340533
		public FBasicParticleData()
		{
		}

		// Token: 0x06023401 RID: 144385 RVA: 0x0034233B File Offset: 0x0034053B
		public FBasicParticleData(FVector Position, float Size, FVector Velocity)
		{
			this.Position = Position;
			this.Size = Size;
			this.Velocity = Velocity;
		}

		// Token: 0x06023402 RID: 144386 RVA: 0x00342358 File Offset: 0x00340558
		protected override IntPtr GetUStructPtr()
		{
			return FBasicParticleData.StaticStruct();
		}

		// Token: 0x06023403 RID: 144387 RVA: 0x00342364 File Offset: 0x00340564
		[NullableContext(2)]
		public FBasicParticleData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023404 RID: 144388 RVA: 0x0034236E File Offset: 0x0034056E
		public FBasicParticleData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023405 RID: 144389 RVA: 0x00342379 File Offset: 0x00340579
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBasicParticleData(Pointer, false, true);
		}

		// Token: 0x06023406 RID: 144390 RVA: 0x00342383 File Offset: 0x00340583
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBasicParticleData(Pointer, MemoryOwner);
		}

		// Token: 0x04012D5C RID: 77148
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.BasicParticleData";

		// Token: 0x04012D5D RID: 77149
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012D5E RID: 77150
		internal static int __PropertyOffset_Position;

		// Token: 0x04012D5F RID: 77151
		internal static int __PropertyOffset_Size;

		// Token: 0x04012D60 RID: 77152
		internal static int __PropertyOffset_Velocity;
	}
}
