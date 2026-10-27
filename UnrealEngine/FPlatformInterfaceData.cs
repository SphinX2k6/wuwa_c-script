using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FFF RID: 4095
	[UnrealObjectPath("/Script/Engine.PlatformInterfaceData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FPlatformInterfaceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DDBF RID: 56767 RVA: 0x00146AC6 File Offset: 0x00144CC6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPlatformInterfaceData._ScriptStructPtr != 0) ? FPlatformInterfaceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PlatformInterfaceData", ref FPlatformInterfaceData._ScriptStructPtr);
		}

		// Token: 0x1700344B RID: 13387
		// (get) Token: 0x0600DDC0 RID: 56768 RVA: 0x00146AEA File Offset: 0x00144CEA
		// (set) Token: 0x0600DDC1 RID: 56769 RVA: 0x00146AFE File Offset: 0x00144CFE
		public unsafe FName DataName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlatformInterfaceData.__PropertyOffset_DataName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlatformInterfaceData.__PropertyOffset_DataName) = value;
			}
		}

		// Token: 0x1700344C RID: 13388
		// (get) Token: 0x0600DDC2 RID: 56770 RVA: 0x00146B13 File Offset: 0x00144D13
		// (set) Token: 0x0600DDC3 RID: 56771 RVA: 0x00146B27 File Offset: 0x00144D27
		public unsafe TEnumAsByte<EPlatformInterfaceDataType> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlatformInterfaceData.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlatformInterfaceData.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x1700344D RID: 13389
		// (get) Token: 0x0600DDC4 RID: 56772 RVA: 0x00146B3C File Offset: 0x00144D3C
		// (set) Token: 0x0600DDC5 RID: 56773 RVA: 0x00146B4C File Offset: 0x00144D4C
		public unsafe int IntValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlatformInterfaceData.__PropertyOffset_IntValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlatformInterfaceData.__PropertyOffset_IntValue) = value;
			}
		}

		// Token: 0x1700344E RID: 13390
		// (get) Token: 0x0600DDC6 RID: 56774 RVA: 0x00146B5D File Offset: 0x00144D5D
		// (set) Token: 0x0600DDC7 RID: 56775 RVA: 0x00146B6D File Offset: 0x00144D6D
		public unsafe float FloatValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlatformInterfaceData.__PropertyOffset_FloatValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlatformInterfaceData.__PropertyOffset_FloatValue) = value;
			}
		}

		// Token: 0x1700344F RID: 13391
		// (get) Token: 0x0600DDC8 RID: 56776 RVA: 0x00146B7E File Offset: 0x00144D7E
		// (set) Token: 0x0600DDC9 RID: 56777 RVA: 0x00146B92 File Offset: 0x00144D92
		[Nullable(1)]
		public unsafe string StringValue
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPlatformInterfaceData.__PropertyOffset_StringValue)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPlatformInterfaceData.__PropertyOffset_StringValue)), value);
			}
		}

		// Token: 0x17003450 RID: 13392
		// (get) Token: 0x0600DDCA RID: 56778 RVA: 0x00146BA7 File Offset: 0x00144DA7
		// (set) Token: 0x0600DDCB RID: 56779 RVA: 0x00146BBB File Offset: 0x00144DBB
		[Nullable(2)]
		public unsafe UObject ObjectValue
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FPlatformInterfaceData.__PropertyOffset_ObjectValue);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPlatformInterfaceData.__PropertyOffset_ObjectValue, value);
			}
		}

		// Token: 0x0600DDCC RID: 56780 RVA: 0x00146BD0 File Offset: 0x00144DD0
		public FPlatformInterfaceData()
		{
		}

		// Token: 0x0600DDCD RID: 56781 RVA: 0x00146BD8 File Offset: 0x00144DD8
		[NullableContext(1)]
		public FPlatformInterfaceData(FName DataName, [Nullable(0)] TEnumAsByte<EPlatformInterfaceDataType> Type, int IntValue, float FloatValue, string StringValue, UObject ObjectValue)
		{
			this.DataName = DataName;
			this.Type = Type;
			this.IntValue = IntValue;
			this.FloatValue = FloatValue;
			this.StringValue = StringValue;
			this.ObjectValue = ObjectValue;
		}

		// Token: 0x0600DDCE RID: 56782 RVA: 0x00146C0D File Offset: 0x00144E0D
		protected override IntPtr GetUStructPtr()
		{
			return FPlatformInterfaceData.StaticStruct();
		}

		// Token: 0x0600DDCF RID: 56783 RVA: 0x00146C19 File Offset: 0x00144E19
		[NullableContext(2)]
		public FPlatformInterfaceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DDD0 RID: 56784 RVA: 0x00146C23 File Offset: 0x00144E23
		public FPlatformInterfaceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DDD1 RID: 56785 RVA: 0x00146C2E File Offset: 0x00144E2E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPlatformInterfaceData(Pointer, false, true);
		}

		// Token: 0x0600DDD2 RID: 56786 RVA: 0x00146C38 File Offset: 0x00144E38
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPlatformInterfaceData(Pointer, MemoryOwner);
		}

		// Token: 0x040077E6 RID: 30694
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PlatformInterfaceData";

		// Token: 0x040077E7 RID: 30695
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040077E8 RID: 30696
		internal static int __PropertyOffset_DataName;

		// Token: 0x040077E9 RID: 30697
		internal static int __PropertyOffset_Type;

		// Token: 0x040077EA RID: 30698
		internal static int __PropertyOffset_IntValue;

		// Token: 0x040077EB RID: 30699
		internal static int __PropertyOffset_FloatValue;

		// Token: 0x040077EC RID: 30700
		internal static int __PropertyOffset_StringValue;

		// Token: 0x040077ED RID: 30701
		internal static int __PropertyOffset_ObjectValue;
	}
}
