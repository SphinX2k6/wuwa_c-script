using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EB4 RID: 3764
	[UnrealObjectPath("/Script/Engine.ModulatorContinuousParams")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FModulatorContinuousParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CBA9 RID: 52137 RVA: 0x00128E57 File Offset: 0x00127057
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FModulatorContinuousParams._ScriptStructPtr != 0) ? FModulatorContinuousParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ModulatorContinuousParams", ref FModulatorContinuousParams._ScriptStructPtr);
		}

		// Token: 0x17002FEB RID: 12267
		// (get) Token: 0x0600CBAA RID: 52138 RVA: 0x00128E7B File Offset: 0x0012707B
		// (set) Token: 0x0600CBAB RID: 52139 RVA: 0x00128E8F File Offset: 0x0012708F
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FModulatorContinuousParams.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FModulatorContinuousParams.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17002FEC RID: 12268
		// (get) Token: 0x0600CBAC RID: 52140 RVA: 0x00128EA4 File Offset: 0x001270A4
		// (set) Token: 0x0600CBAD RID: 52141 RVA: 0x00128EB4 File Offset: 0x001270B4
		public unsafe float Default
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FModulatorContinuousParams.__PropertyOffset_Default);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FModulatorContinuousParams.__PropertyOffset_Default) = value;
			}
		}

		// Token: 0x17002FED RID: 12269
		// (get) Token: 0x0600CBAE RID: 52142 RVA: 0x00128EC5 File Offset: 0x001270C5
		// (set) Token: 0x0600CBAF RID: 52143 RVA: 0x00128ED5 File Offset: 0x001270D5
		public unsafe float MinInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FModulatorContinuousParams.__PropertyOffset_MinInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FModulatorContinuousParams.__PropertyOffset_MinInput) = value;
			}
		}

		// Token: 0x17002FEE RID: 12270
		// (get) Token: 0x0600CBB0 RID: 52144 RVA: 0x00128EE6 File Offset: 0x001270E6
		// (set) Token: 0x0600CBB1 RID: 52145 RVA: 0x00128EF6 File Offset: 0x001270F6
		public unsafe float MaxInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FModulatorContinuousParams.__PropertyOffset_MaxInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FModulatorContinuousParams.__PropertyOffset_MaxInput) = value;
			}
		}

		// Token: 0x17002FEF RID: 12271
		// (get) Token: 0x0600CBB2 RID: 52146 RVA: 0x00128F07 File Offset: 0x00127107
		// (set) Token: 0x0600CBB3 RID: 52147 RVA: 0x00128F17 File Offset: 0x00127117
		public unsafe float MinOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FModulatorContinuousParams.__PropertyOffset_MinOutput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FModulatorContinuousParams.__PropertyOffset_MinOutput) = value;
			}
		}

		// Token: 0x17002FF0 RID: 12272
		// (get) Token: 0x0600CBB4 RID: 52148 RVA: 0x00128F28 File Offset: 0x00127128
		// (set) Token: 0x0600CBB5 RID: 52149 RVA: 0x00128F38 File Offset: 0x00127138
		public unsafe float MaxOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FModulatorContinuousParams.__PropertyOffset_MaxOutput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FModulatorContinuousParams.__PropertyOffset_MaxOutput) = value;
			}
		}

		// Token: 0x17002FF1 RID: 12273
		// (get) Token: 0x0600CBB6 RID: 52150 RVA: 0x00128F49 File Offset: 0x00127149
		// (set) Token: 0x0600CBB7 RID: 52151 RVA: 0x00128F5D File Offset: 0x0012715D
		public unsafe TEnumAsByte<ModulationParamMode> ParamMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FModulatorContinuousParams.__PropertyOffset_ParamMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FModulatorContinuousParams.__PropertyOffset_ParamMode) = value;
			}
		}

		// Token: 0x0600CBB8 RID: 52152 RVA: 0x00128F72 File Offset: 0x00127172
		public FModulatorContinuousParams()
		{
		}

		// Token: 0x0600CBB9 RID: 52153 RVA: 0x00128F7A File Offset: 0x0012717A
		public FModulatorContinuousParams(FName ParameterName, float Default, float MinInput, float MaxInput, float MinOutput, float MaxOutput, TEnumAsByte<ModulationParamMode> ParamMode)
		{
			this.ParameterName = ParameterName;
			this.Default = Default;
			this.MinInput = MinInput;
			this.MaxInput = MaxInput;
			this.MinOutput = MinOutput;
			this.MaxOutput = MaxOutput;
			this.ParamMode = ParamMode;
		}

		// Token: 0x0600CBBA RID: 52154 RVA: 0x00128FB7 File Offset: 0x001271B7
		protected override IntPtr GetUStructPtr()
		{
			return FModulatorContinuousParams.StaticStruct();
		}

		// Token: 0x0600CBBB RID: 52155 RVA: 0x00128FC3 File Offset: 0x001271C3
		[NullableContext(2)]
		public FModulatorContinuousParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CBBC RID: 52156 RVA: 0x00128FCD File Offset: 0x001271CD
		public FModulatorContinuousParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CBBD RID: 52157 RVA: 0x00128FD8 File Offset: 0x001271D8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FModulatorContinuousParams(Pointer, false, true);
		}

		// Token: 0x0600CBBE RID: 52158 RVA: 0x00128FE2 File Offset: 0x001271E2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FModulatorContinuousParams(Pointer, MemoryOwner);
		}

		// Token: 0x04006DC3 RID: 28099
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ModulatorContinuousParams";

		// Token: 0x04006DC4 RID: 28100
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006DC5 RID: 28101
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04006DC6 RID: 28102
		internal static int __PropertyOffset_Default;

		// Token: 0x04006DC7 RID: 28103
		internal static int __PropertyOffset_MinInput;

		// Token: 0x04006DC8 RID: 28104
		internal static int __PropertyOffset_MaxInput;

		// Token: 0x04006DC9 RID: 28105
		internal static int __PropertyOffset_MinOutput;

		// Token: 0x04006DCA RID: 28106
		internal static int __PropertyOffset_MaxOutput;

		// Token: 0x04006DCB RID: 28107
		internal static int __PropertyOffset_ParamMode;
	}
}
