using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001AFF RID: 6911
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFlockingData")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FKuroFlockingData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019D6E RID: 105838 RVA: 0x002627EF File Offset: 0x002609EF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroFlockingData._ScriptStructPtr != 0) ? FKuroFlockingData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroFlockingData", ref FKuroFlockingData._ScriptStructPtr);
		}

		// Token: 0x17006776 RID: 26486
		// (get) Token: 0x06019D6F RID: 105839 RVA: 0x00262813 File Offset: 0x00260A13
		// (set) Token: 0x06019D70 RID: 105840 RVA: 0x00262827 File Offset: 0x00260A27
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingData.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingData.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17006777 RID: 26487
		// (get) Token: 0x06019D71 RID: 105841 RVA: 0x0026283C File Offset: 0x00260A3C
		// (set) Token: 0x06019D72 RID: 105842 RVA: 0x00262850 File Offset: 0x00260A50
		public unsafe FVector Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingData.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingData.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x17006778 RID: 26488
		// (get) Token: 0x06019D73 RID: 105843 RVA: 0x00262865 File Offset: 0x00260A65
		// (set) Token: 0x06019D74 RID: 105844 RVA: 0x00262879 File Offset: 0x00260A79
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlockingData.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlockingData.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x06019D75 RID: 105845 RVA: 0x0026288E File Offset: 0x00260A8E
		public FKuroFlockingData()
		{
		}

		// Token: 0x06019D76 RID: 105846 RVA: 0x00262896 File Offset: 0x00260A96
		public FKuroFlockingData(FVector Position, FVector Direction, FVector Velocity)
		{
			this.Position = Position;
			this.Direction = Direction;
			this.Velocity = Velocity;
		}

		// Token: 0x06019D77 RID: 105847 RVA: 0x002628B3 File Offset: 0x00260AB3
		protected override IntPtr GetUStructPtr()
		{
			return FKuroFlockingData.StaticStruct();
		}

		// Token: 0x06019D78 RID: 105848 RVA: 0x002628BF File Offset: 0x00260ABF
		[NullableContext(2)]
		public FKuroFlockingData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019D79 RID: 105849 RVA: 0x002628C9 File Offset: 0x00260AC9
		public FKuroFlockingData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019D7A RID: 105850 RVA: 0x002628D4 File Offset: 0x00260AD4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroFlockingData(Pointer, false, true);
		}

		// Token: 0x06019D7B RID: 105851 RVA: 0x002628DE File Offset: 0x00260ADE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroFlockingData(Pointer, MemoryOwner);
		}

		// Token: 0x0400E0D1 RID: 57553
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFlockingData";

		// Token: 0x0400E0D2 RID: 57554
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E0D3 RID: 57555
		internal static int __PropertyOffset_Position;

		// Token: 0x0400E0D4 RID: 57556
		internal static int __PropertyOffset_Direction;

		// Token: 0x0400E0D5 RID: 57557
		internal static int __PropertyOffset_Velocity;
	}
}
