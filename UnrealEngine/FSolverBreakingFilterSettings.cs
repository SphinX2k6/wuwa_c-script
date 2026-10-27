using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200046B RID: 1131
	[UnrealObjectPath("/Script/Chaos.SolverBreakingFilterSettings")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSolverBreakingFilterSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003C48 RID: 15432 RVA: 0x0005AE4B File Offset: 0x0005904B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSolverBreakingFilterSettings._ScriptStructPtr != 0) ? FSolverBreakingFilterSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Chaos.SolverBreakingFilterSettings", ref FSolverBreakingFilterSettings._ScriptStructPtr);
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06003C49 RID: 15433 RVA: 0x0005AE6F File Offset: 0x0005906F
		// (set) Token: 0x06003C4A RID: 15434 RVA: 0x0005AE7F File Offset: 0x0005907F
		public unsafe bool FilterEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverBreakingFilterSettings.__PropertyOffset_FilterEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverBreakingFilterSettings.__PropertyOffset_FilterEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06003C4B RID: 15435 RVA: 0x0005AE90 File Offset: 0x00059090
		// (set) Token: 0x06003C4C RID: 15436 RVA: 0x0005AEA0 File Offset: 0x000590A0
		public unsafe float MinMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverBreakingFilterSettings.__PropertyOffset_MinMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverBreakingFilterSettings.__PropertyOffset_MinMass) = value;
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06003C4D RID: 15437 RVA: 0x0005AEB1 File Offset: 0x000590B1
		// (set) Token: 0x06003C4E RID: 15438 RVA: 0x0005AEC1 File Offset: 0x000590C1
		public unsafe float MinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverBreakingFilterSettings.__PropertyOffset_MinSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverBreakingFilterSettings.__PropertyOffset_MinSpeed) = value;
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06003C4F RID: 15439 RVA: 0x0005AED2 File Offset: 0x000590D2
		// (set) Token: 0x06003C50 RID: 15440 RVA: 0x0005AEE2 File Offset: 0x000590E2
		public unsafe float MinVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverBreakingFilterSettings.__PropertyOffset_MinVolume);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverBreakingFilterSettings.__PropertyOffset_MinVolume) = value;
			}
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x0005AEF3 File Offset: 0x000590F3
		public FSolverBreakingFilterSettings()
		{
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x0005AEFB File Offset: 0x000590FB
		public FSolverBreakingFilterSettings(bool FilterEnabled, float MinMass, float MinSpeed, float MinVolume)
		{
			this.FilterEnabled = FilterEnabled;
			this.MinMass = MinMass;
			this.MinSpeed = MinSpeed;
			this.MinVolume = MinVolume;
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x0005AF20 File Offset: 0x00059120
		protected override IntPtr GetUStructPtr()
		{
			return FSolverBreakingFilterSettings.StaticStruct();
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x0005AF2C File Offset: 0x0005912C
		[NullableContext(2)]
		public FSolverBreakingFilterSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x0005AF36 File Offset: 0x00059136
		public FSolverBreakingFilterSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x0005AF41 File Offset: 0x00059141
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSolverBreakingFilterSettings(Pointer, false, true);
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x0005AF4B File Offset: 0x0005914B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSolverBreakingFilterSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04001C4A RID: 7242
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Chaos.SolverBreakingFilterSettings";

		// Token: 0x04001C4B RID: 7243
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001C4C RID: 7244
		internal static int __PropertyOffset_FilterEnabled;

		// Token: 0x04001C4D RID: 7245
		internal static int __PropertyOffset_MinMass;

		// Token: 0x04001C4E RID: 7246
		internal static int __PropertyOffset_MinSpeed;

		// Token: 0x04001C4F RID: 7247
		internal static int __PropertyOffset_MinVolume;
	}
}
