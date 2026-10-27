using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001421 RID: 5153
	[UnrealObjectPath("/Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FChaosTrailingEventRequestSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012D03 RID: 77059 RVA: 0x001BAC63 File Offset: 0x001B8E63
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChaosTrailingEventRequestSettings._ScriptStructPtr != 0) ? FChaosTrailingEventRequestSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings", ref FChaosTrailingEventRequestSettings._ScriptStructPtr);
		}

		// Token: 0x170048DD RID: 18653
		// (get) Token: 0x06012D04 RID: 77060 RVA: 0x001BAC87 File Offset: 0x001B8E87
		// (set) Token: 0x06012D05 RID: 77061 RVA: 0x001BAC97 File Offset: 0x001B8E97
		public unsafe int MaxNumberOfResults
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosTrailingEventRequestSettings.__PropertyOffset_MaxNumberOfResults);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosTrailingEventRequestSettings.__PropertyOffset_MaxNumberOfResults) = value;
			}
		}

		// Token: 0x170048DE RID: 18654
		// (get) Token: 0x06012D06 RID: 77062 RVA: 0x001BACA8 File Offset: 0x001B8EA8
		// (set) Token: 0x06012D07 RID: 77063 RVA: 0x001BACB8 File Offset: 0x001B8EB8
		public unsafe float MinMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosTrailingEventRequestSettings.__PropertyOffset_MinMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosTrailingEventRequestSettings.__PropertyOffset_MinMass) = value;
			}
		}

		// Token: 0x170048DF RID: 18655
		// (get) Token: 0x06012D08 RID: 77064 RVA: 0x001BACC9 File Offset: 0x001B8EC9
		// (set) Token: 0x06012D09 RID: 77065 RVA: 0x001BACD9 File Offset: 0x001B8ED9
		public unsafe float MinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosTrailingEventRequestSettings.__PropertyOffset_MinSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosTrailingEventRequestSettings.__PropertyOffset_MinSpeed) = value;
			}
		}

		// Token: 0x170048E0 RID: 18656
		// (get) Token: 0x06012D0A RID: 77066 RVA: 0x001BACEA File Offset: 0x001B8EEA
		// (set) Token: 0x06012D0B RID: 77067 RVA: 0x001BACFA File Offset: 0x001B8EFA
		public unsafe float MinAngularSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosTrailingEventRequestSettings.__PropertyOffset_MinAngularSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosTrailingEventRequestSettings.__PropertyOffset_MinAngularSpeed) = value;
			}
		}

		// Token: 0x170048E1 RID: 18657
		// (get) Token: 0x06012D0C RID: 77068 RVA: 0x001BAD0B File Offset: 0x001B8F0B
		// (set) Token: 0x06012D0D RID: 77069 RVA: 0x001BAD1B File Offset: 0x001B8F1B
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosTrailingEventRequestSettings.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosTrailingEventRequestSettings.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x170048E2 RID: 18658
		// (get) Token: 0x06012D0E RID: 77070 RVA: 0x001BAD2C File Offset: 0x001B8F2C
		// (set) Token: 0x06012D0F RID: 77071 RVA: 0x001BAD3C File Offset: 0x001B8F3C
		public unsafe EChaosTrailingSortMethod SortMethod
		{
			get
			{
				return (EChaosTrailingSortMethod)(*(base.NativePtr + (IntPtr)FChaosTrailingEventRequestSettings.__PropertyOffset_SortMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosTrailingEventRequestSettings.__PropertyOffset_SortMethod) = (byte)value;
			}
		}

		// Token: 0x06012D10 RID: 77072 RVA: 0x001BAD4D File Offset: 0x001B8F4D
		public FChaosTrailingEventRequestSettings()
		{
		}

		// Token: 0x06012D11 RID: 77073 RVA: 0x001BAD55 File Offset: 0x001B8F55
		public FChaosTrailingEventRequestSettings(int MaxNumberOfResults, float MinMass, float MinSpeed, float MinAngularSpeed, float MaxDistance, EChaosTrailingSortMethod SortMethod)
		{
			this.MaxNumberOfResults = MaxNumberOfResults;
			this.MinMass = MinMass;
			this.MinSpeed = MinSpeed;
			this.MinAngularSpeed = MinAngularSpeed;
			this.MaxDistance = MaxDistance;
			this.SortMethod = SortMethod;
		}

		// Token: 0x06012D12 RID: 77074 RVA: 0x001BAD8A File Offset: 0x001B8F8A
		protected override IntPtr GetUStructPtr()
		{
			return FChaosTrailingEventRequestSettings.StaticStruct();
		}

		// Token: 0x06012D13 RID: 77075 RVA: 0x001BAD96 File Offset: 0x001B8F96
		[NullableContext(2)]
		public FChaosTrailingEventRequestSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012D14 RID: 77076 RVA: 0x001BADA0 File Offset: 0x001B8FA0
		public FChaosTrailingEventRequestSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012D15 RID: 77077 RVA: 0x001BADAB File Offset: 0x001B8FAB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChaosTrailingEventRequestSettings(Pointer, false, true);
		}

		// Token: 0x06012D16 RID: 77078 RVA: 0x001BADB5 File Offset: 0x001B8FB5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChaosTrailingEventRequestSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400A0C3 RID: 41155
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings";

		// Token: 0x0400A0C4 RID: 41156
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A0C5 RID: 41157
		internal static int __PropertyOffset_MaxNumberOfResults;

		// Token: 0x0400A0C6 RID: 41158
		internal static int __PropertyOffset_MinMass;

		// Token: 0x0400A0C7 RID: 41159
		internal static int __PropertyOffset_MinSpeed;

		// Token: 0x0400A0C8 RID: 41160
		internal static int __PropertyOffset_MinAngularSpeed;

		// Token: 0x0400A0C9 RID: 41161
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x0400A0CA RID: 41162
		internal static int __PropertyOffset_SortMethod;
	}
}
