using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D92 RID: 3474
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionBranch")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionBranch : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD76 RID: 48502 RVA: 0x0010F0BB File Offset: 0x0010D2BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionBranch._ClassPtr;
		}

		// Token: 0x0600BD77 RID: 48503 RVA: 0x0010F0C8 File Offset: 0x0010D2C8
		public UMaterialExpressionBranch() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionBranch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD78 RID: 48504 RVA: 0x0010F0F0 File Offset: 0x0010D2F0
		public UMaterialExpressionBranch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionBranch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x0600BD79 RID: 48505 RVA: 0x0010F124 File Offset: 0x0010D324
		// (set) Token: 0x0600BD7A RID: 48506 RVA: 0x0010F15D File Offset: 0x0010D35D
		public TArray<FExpressionInput> EqualInputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FExpressionInput> result;
				if ((result = this._EqualInputs) == null)
				{
					result = (this._EqualInputs = new TArray<FExpressionInput>(base.NativePtr + (IntPtr)UMaterialExpressionBranch.__PropertyOffset_EqualInputs, this));
				}
				return result;
			}
			set
			{
				this.EqualInputs.CopyAssign(value);
			}
		}

		// Token: 0x17002BF0 RID: 11248
		// (get) Token: 0x0600BD7B RID: 48507 RVA: 0x0010F16C File Offset: 0x0010D36C
		// (set) Token: 0x0600BD7C RID: 48508 RVA: 0x0010F1A5 File Offset: 0x0010D3A5
		public TArray<FExpressionInput> IfInputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FExpressionInput> result;
				if ((result = this._IfInputs) == null)
				{
					result = (this._IfInputs = new TArray<FExpressionInput>(base.NativePtr + (IntPtr)UMaterialExpressionBranch.__PropertyOffset_IfInputs, this));
				}
				return result;
			}
			set
			{
				this.IfInputs.CopyAssign(value);
			}
		}

		// Token: 0x17002BF1 RID: 11249
		// (get) Token: 0x0600BD7D RID: 48509 RVA: 0x0010F1B4 File Offset: 0x0010D3B4
		// (set) Token: 0x0600BD7E RID: 48510 RVA: 0x0010F1ED File Offset: 0x0010D3ED
		public FExpressionInput ElseInput
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ElseInput) == null)
				{
					result = (this._ElseInput = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionBranch.__PropertyOffset_ElseInput, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionBranch.__PropertyOffset_ElseInput, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002BF2 RID: 11250
		// (get) Token: 0x0600BD7F RID: 48511 RVA: 0x0010F20E File Offset: 0x0010D40E
		// (set) Token: 0x0600BD80 RID: 48512 RVA: 0x0010F21E File Offset: 0x0010D41E
		public unsafe byte EqualConditions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionBranch.__PropertyOffset_EqualConditions);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionBranch.__PropertyOffset_EqualConditions) = value;
			}
		}

		// Token: 0x17002BF3 RID: 11251
		// (get) Token: 0x0600BD81 RID: 48513 RVA: 0x0010F22F File Offset: 0x0010D42F
		// (set) Token: 0x0600BD82 RID: 48514 RVA: 0x0010F23F File Offset: 0x0010D43F
		public unsafe byte IfConditions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionBranch.__PropertyOffset_IfConditions);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionBranch.__PropertyOffset_IfConditions) = value;
			}
		}

		// Token: 0x17002BF4 RID: 11252
		// (get) Token: 0x0600BD83 RID: 48515 RVA: 0x0010F250 File Offset: 0x0010D450
		// (set) Token: 0x0600BD84 RID: 48516 RVA: 0x0010F260 File Offset: 0x0010D460
		public unsafe byte AmountOfOutputs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionBranch.__PropertyOffset_AmountOfOutputs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionBranch.__PropertyOffset_AmountOfOutputs) = value;
			}
		}

		// Token: 0x17002BF5 RID: 11253
		// (get) Token: 0x0600BD85 RID: 48517 RVA: 0x0010F274 File Offset: 0x0010D474
		// (set) Token: 0x0600BD86 RID: 48518 RVA: 0x0010F2AD File Offset: 0x0010D4AD
		public TArray<string> OutputNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._OutputNames) == null)
				{
					result = (this._OutputNames = new TArray<string>(base.NativePtr + (IntPtr)UMaterialExpressionBranch.__PropertyOffset_OutputNames, this));
				}
				return result;
			}
			set
			{
				this.OutputNames.CopyAssign(value);
			}
		}

		// Token: 0x0600BD87 RID: 48519 RVA: 0x0010F2BB File Offset: 0x0010D4BB
		static UMaterialExpressionBranch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionBranch");
		}

		// Token: 0x0600BD88 RID: 48520 RVA: 0x0010F2C9 File Offset: 0x0010D4C9
		protected UMaterialExpressionBranch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006401 RID: 25601
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionBranch";

		// Token: 0x04006402 RID: 25602
		private static IntPtr _ClassPtr;

		// Token: 0x04006403 RID: 25603
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006404 RID: 25604
		internal static int __PropertyOffset_EqualInputs;

		// Token: 0x04006405 RID: 25605
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FExpressionInput> _EqualInputs;

		// Token: 0x04006406 RID: 25606
		internal static int __PropertyOffset_IfInputs;

		// Token: 0x04006407 RID: 25607
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FExpressionInput> _IfInputs;

		// Token: 0x04006408 RID: 25608
		internal static int __PropertyOffset_ElseInput;

		// Token: 0x04006409 RID: 25609
		[Nullable(2)]
		private FExpressionInput _ElseInput;

		// Token: 0x0400640A RID: 25610
		internal static int __PropertyOffset_EqualConditions;

		// Token: 0x0400640B RID: 25611
		internal static int __PropertyOffset_IfConditions;

		// Token: 0x0400640C RID: 25612
		internal static int __PropertyOffset_AmountOfOutputs;

		// Token: 0x0400640D RID: 25613
		internal static int __PropertyOffset_OutputNames;

		// Token: 0x0400640E RID: 25614
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _OutputNames;
	}
}
