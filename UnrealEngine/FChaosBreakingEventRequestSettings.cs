using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200141C RID: 5148
	[UnrealObjectPath("/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FChaosBreakingEventRequestSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012C7C RID: 76924 RVA: 0x001BA147 File Offset: 0x001B8347
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChaosBreakingEventRequestSettings._ScriptStructPtr != 0) ? FChaosBreakingEventRequestSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings", ref FChaosBreakingEventRequestSettings._ScriptStructPtr);
		}

		// Token: 0x170048BA RID: 18618
		// (get) Token: 0x06012C7D RID: 76925 RVA: 0x001BA16B File Offset: 0x001B836B
		// (set) Token: 0x06012C7E RID: 76926 RVA: 0x001BA17B File Offset: 0x001B837B
		public unsafe int MaxNumberOfResults
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosBreakingEventRequestSettings.__PropertyOffset_MaxNumberOfResults);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosBreakingEventRequestSettings.__PropertyOffset_MaxNumberOfResults) = value;
			}
		}

		// Token: 0x170048BB RID: 18619
		// (get) Token: 0x06012C7F RID: 76927 RVA: 0x001BA18C File Offset: 0x001B838C
		// (set) Token: 0x06012C80 RID: 76928 RVA: 0x001BA19C File Offset: 0x001B839C
		public unsafe float MinRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosBreakingEventRequestSettings.__PropertyOffset_MinRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosBreakingEventRequestSettings.__PropertyOffset_MinRadius) = value;
			}
		}

		// Token: 0x170048BC RID: 18620
		// (get) Token: 0x06012C81 RID: 76929 RVA: 0x001BA1AD File Offset: 0x001B83AD
		// (set) Token: 0x06012C82 RID: 76930 RVA: 0x001BA1BD File Offset: 0x001B83BD
		public unsafe float MinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosBreakingEventRequestSettings.__PropertyOffset_MinSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosBreakingEventRequestSettings.__PropertyOffset_MinSpeed) = value;
			}
		}

		// Token: 0x170048BD RID: 18621
		// (get) Token: 0x06012C83 RID: 76931 RVA: 0x001BA1CE File Offset: 0x001B83CE
		// (set) Token: 0x06012C84 RID: 76932 RVA: 0x001BA1DE File Offset: 0x001B83DE
		public unsafe float MinMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosBreakingEventRequestSettings.__PropertyOffset_MinMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosBreakingEventRequestSettings.__PropertyOffset_MinMass) = value;
			}
		}

		// Token: 0x170048BE RID: 18622
		// (get) Token: 0x06012C85 RID: 76933 RVA: 0x001BA1EF File Offset: 0x001B83EF
		// (set) Token: 0x06012C86 RID: 76934 RVA: 0x001BA1FF File Offset: 0x001B83FF
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosBreakingEventRequestSettings.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosBreakingEventRequestSettings.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x170048BF RID: 18623
		// (get) Token: 0x06012C87 RID: 76935 RVA: 0x001BA210 File Offset: 0x001B8410
		// (set) Token: 0x06012C88 RID: 76936 RVA: 0x001BA220 File Offset: 0x001B8420
		public unsafe EChaosBreakingSortMethod SortMethod
		{
			get
			{
				return (EChaosBreakingSortMethod)(*(base.NativePtr + (IntPtr)FChaosBreakingEventRequestSettings.__PropertyOffset_SortMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosBreakingEventRequestSettings.__PropertyOffset_SortMethod) = (byte)value;
			}
		}

		// Token: 0x06012C89 RID: 76937 RVA: 0x001BA231 File Offset: 0x001B8431
		public FChaosBreakingEventRequestSettings()
		{
		}

		// Token: 0x06012C8A RID: 76938 RVA: 0x001BA239 File Offset: 0x001B8439
		public FChaosBreakingEventRequestSettings(int MaxNumberOfResults, float MinRadius, float MinSpeed, float MinMass, float MaxDistance, EChaosBreakingSortMethod SortMethod)
		{
			this.MaxNumberOfResults = MaxNumberOfResults;
			this.MinRadius = MinRadius;
			this.MinSpeed = MinSpeed;
			this.MinMass = MinMass;
			this.MaxDistance = MaxDistance;
			this.SortMethod = SortMethod;
		}

		// Token: 0x06012C8B RID: 76939 RVA: 0x001BA26E File Offset: 0x001B846E
		protected override IntPtr GetUStructPtr()
		{
			return FChaosBreakingEventRequestSettings.StaticStruct();
		}

		// Token: 0x06012C8C RID: 76940 RVA: 0x001BA27A File Offset: 0x001B847A
		[NullableContext(2)]
		public FChaosBreakingEventRequestSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012C8D RID: 76941 RVA: 0x001BA284 File Offset: 0x001B8484
		public FChaosBreakingEventRequestSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012C8E RID: 76942 RVA: 0x001BA28F File Offset: 0x001B848F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChaosBreakingEventRequestSettings(Pointer, false, true);
		}

		// Token: 0x06012C8F RID: 76943 RVA: 0x001BA299 File Offset: 0x001B8499
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChaosBreakingEventRequestSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400A08A RID: 41098
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings";

		// Token: 0x0400A08B RID: 41099
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A08C RID: 41100
		internal static int __PropertyOffset_MaxNumberOfResults;

		// Token: 0x0400A08D RID: 41101
		internal static int __PropertyOffset_MinRadius;

		// Token: 0x0400A08E RID: 41102
		internal static int __PropertyOffset_MinSpeed;

		// Token: 0x0400A08F RID: 41103
		internal static int __PropertyOffset_MinMass;

		// Token: 0x0400A090 RID: 41104
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x0400A091 RID: 41105
		internal static int __PropertyOffset_SortMethod;
	}
}
