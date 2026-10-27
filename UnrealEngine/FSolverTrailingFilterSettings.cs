using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200046F RID: 1135
	[UnrealObjectPath("/Script/Chaos.SolverTrailingFilterSettings")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSolverTrailingFilterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003C9E RID: 15518 RVA: 0x0005B490 File Offset: 0x00059690
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSolverTrailingFilterSettings._ScriptStructPtr != 0) ? FSolverTrailingFilterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Chaos.SolverTrailingFilterSettings", ref FSolverTrailingFilterSettings._ScriptStructPtr);
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06003C9F RID: 15519 RVA: 0x0005B4B4 File Offset: 0x000596B4
		// (set) Token: 0x06003CA0 RID: 15520 RVA: 0x0005B4C4 File Offset: 0x000596C4
		public unsafe bool FilterEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverTrailingFilterSettings.__PropertyOffset_FilterEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverTrailingFilterSettings.__PropertyOffset_FilterEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06003CA1 RID: 15521 RVA: 0x0005B4D5 File Offset: 0x000596D5
		// (set) Token: 0x06003CA2 RID: 15522 RVA: 0x0005B4E5 File Offset: 0x000596E5
		public unsafe float MinMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverTrailingFilterSettings.__PropertyOffset_MinMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverTrailingFilterSettings.__PropertyOffset_MinMass) = value;
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06003CA3 RID: 15523 RVA: 0x0005B4F6 File Offset: 0x000596F6
		// (set) Token: 0x06003CA4 RID: 15524 RVA: 0x0005B506 File Offset: 0x00059706
		public unsafe float MinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverTrailingFilterSettings.__PropertyOffset_MinSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverTrailingFilterSettings.__PropertyOffset_MinSpeed) = value;
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06003CA5 RID: 15525 RVA: 0x0005B517 File Offset: 0x00059717
		// (set) Token: 0x06003CA6 RID: 15526 RVA: 0x0005B527 File Offset: 0x00059727
		public unsafe float MinVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverTrailingFilterSettings.__PropertyOffset_MinVolume);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverTrailingFilterSettings.__PropertyOffset_MinVolume) = value;
			}
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x0005B538 File Offset: 0x00059738
		public FSolverTrailingFilterSettings()
		{
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x0005B540 File Offset: 0x00059740
		public FSolverTrailingFilterSettings(bool FilterEnabled, float MinMass, float MinSpeed, float MinVolume)
		{
			this.FilterEnabled = FilterEnabled;
			this.MinMass = MinMass;
			this.MinSpeed = MinSpeed;
			this.MinVolume = MinVolume;
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x0005B565 File Offset: 0x00059765
		protected override IntPtr GetUStructPtr()
		{
			return FSolverTrailingFilterSettings.StaticStruct();
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x0005B571 File Offset: 0x00059771
		[NullableContext(2)]
		public FSolverTrailingFilterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x0005B57B File Offset: 0x0005977B
		public FSolverTrailingFilterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x0005B586 File Offset: 0x00059786
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSolverTrailingFilterSettings(Pointer, false, true);
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x0005B590 File Offset: 0x00059790
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSolverTrailingFilterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04001C6D RID: 7277
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Chaos.SolverTrailingFilterSettings";

		// Token: 0x04001C6E RID: 7278
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001C6F RID: 7279
		internal static int __PropertyOffset_FilterEnabled;

		// Token: 0x04001C70 RID: 7280
		internal static int __PropertyOffset_MinMass;

		// Token: 0x04001C71 RID: 7281
		internal static int __PropertyOffset_MinSpeed;

		// Token: 0x04001C72 RID: 7282
		internal static int __PropertyOffset_MinVolume;
	}
}
