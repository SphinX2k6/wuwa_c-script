using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001138 RID: 4408
	[UnrealObjectPath("/Script/Engine.SoundModulationDestinationSettings")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSoundModulationDestinationSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601020C RID: 66060 RVA: 0x0017C36D File Offset: 0x0017A56D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundModulationDestinationSettings._ScriptStructPtr != 0) ? FSoundModulationDestinationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundModulationDestinationSettings", ref FSoundModulationDestinationSettings._ScriptStructPtr);
		}

		// Token: 0x17003F27 RID: 16167
		// (get) Token: 0x0601020D RID: 66061 RVA: 0x0017C391 File Offset: 0x0017A591
		// (set) Token: 0x0601020E RID: 66062 RVA: 0x0017C3A1 File Offset: 0x0017A5A1
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundModulationDestinationSettings.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundModulationDestinationSettings.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17003F28 RID: 16168
		// (get) Token: 0x0601020F RID: 66063 RVA: 0x0017C3B2 File Offset: 0x0017A5B2
		// (set) Token: 0x06010210 RID: 66064 RVA: 0x0017C3C6 File Offset: 0x0017A5C6
		[Nullable(2)]
		public unsafe USoundModulatorBase Modulator
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundModulatorBase>(base.NativePtr / (IntPtr)sizeof(void*) + FSoundModulationDestinationSettings.__PropertyOffset_Modulator);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSoundModulationDestinationSettings.__PropertyOffset_Modulator, value);
			}
		}

		// Token: 0x06010211 RID: 66065 RVA: 0x0017C3DB File Offset: 0x0017A5DB
		public FSoundModulationDestinationSettings()
		{
		}

		// Token: 0x06010212 RID: 66066 RVA: 0x0017C3E3 File Offset: 0x0017A5E3
		[NullableContext(1)]
		public FSoundModulationDestinationSettings(float Value, bool bEnableModulation, USoundModulatorBase Modulator)
		{
			this.Value = Value;
			this.Modulator = Modulator;
		}

		// Token: 0x06010213 RID: 66067 RVA: 0x0017C3F9 File Offset: 0x0017A5F9
		protected override IntPtr GetUStructPtr()
		{
			return FSoundModulationDestinationSettings.StaticStruct();
		}

		// Token: 0x06010214 RID: 66068 RVA: 0x0017C405 File Offset: 0x0017A605
		[NullableContext(2)]
		public FSoundModulationDestinationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010215 RID: 66069 RVA: 0x0017C40F File Offset: 0x0017A60F
		public FSoundModulationDestinationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010216 RID: 66070 RVA: 0x0017C41A File Offset: 0x0017A61A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundModulationDestinationSettings(Pointer, false, true);
		}

		// Token: 0x06010217 RID: 66071 RVA: 0x0017C424 File Offset: 0x0017A624
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundModulationDestinationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04008AC8 RID: 35528
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SoundModulationDestinationSettings";

		// Token: 0x04008AC9 RID: 35529
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008ACA RID: 35530
		internal static int __PropertyOffset_Value;

		// Token: 0x04008ACB RID: 35531
		internal static int __PropertyOffset_Modulator;
	}
}
