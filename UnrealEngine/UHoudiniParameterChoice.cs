using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014EB RID: 5355
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterChoice")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class UHoudiniParameterChoice : UHoudiniParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601366A RID: 79466 RVA: 0x001C866A File Offset: 0x001C686A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterChoice._ClassPtr;
		}

		// Token: 0x0601366B RID: 79467 RVA: 0x001C8678 File Offset: 0x001C6878
		public UHoudiniParameterChoice() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterChoice.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601366C RID: 79468 RVA: 0x001C86A0 File Offset: 0x001C68A0
		public UHoudiniParameterChoice(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterChoice.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BB5 RID: 19381
		// (get) Token: 0x0601366D RID: 79469 RVA: 0x001C86D3 File Offset: 0x001C68D3
		// (set) Token: 0x0601366E RID: 79470 RVA: 0x001C86E3 File Offset: 0x001C68E3
		public unsafe int IntValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterChoice.__PropertyOffset_IntValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterChoice.__PropertyOffset_IntValue) = value;
			}
		}

		// Token: 0x17004BB6 RID: 19382
		// (get) Token: 0x0601366F RID: 79471 RVA: 0x001C86F4 File Offset: 0x001C68F4
		// (set) Token: 0x06013670 RID: 79472 RVA: 0x001C8704 File Offset: 0x001C6904
		public unsafe int DefaultIntValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterChoice.__PropertyOffset_DefaultIntValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterChoice.__PropertyOffset_DefaultIntValue) = value;
			}
		}

		// Token: 0x17004BB7 RID: 19383
		// (get) Token: 0x06013671 RID: 79473 RVA: 0x001C8715 File Offset: 0x001C6915
		// (set) Token: 0x06013672 RID: 79474 RVA: 0x001C8729 File Offset: 0x001C6929
		public unsafe string StringValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameterChoice.__PropertyOffset_StringValue)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameterChoice.__PropertyOffset_StringValue)), value);
			}
		}

		// Token: 0x17004BB8 RID: 19384
		// (get) Token: 0x06013673 RID: 79475 RVA: 0x001C873E File Offset: 0x001C693E
		// (set) Token: 0x06013674 RID: 79476 RVA: 0x001C8752 File Offset: 0x001C6952
		public unsafe string DefaultStringValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameterChoice.__PropertyOffset_DefaultStringValue)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameterChoice.__PropertyOffset_DefaultStringValue)), value);
			}
		}

		// Token: 0x17004BB9 RID: 19385
		// (get) Token: 0x06013675 RID: 79477 RVA: 0x001C8768 File Offset: 0x001C6968
		// (set) Token: 0x06013676 RID: 79478 RVA: 0x001C87A1 File Offset: 0x001C69A1
		public TArray<string> StringChoiceValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StringChoiceValues) == null)
				{
					result = (this._StringChoiceValues = new TArray<string>(base.NativePtr + (IntPtr)UHoudiniParameterChoice.__PropertyOffset_StringChoiceValues, this));
				}
				return result;
			}
			set
			{
				this.StringChoiceValues.CopyAssign(value);
			}
		}

		// Token: 0x17004BBA RID: 19386
		// (get) Token: 0x06013677 RID: 79479 RVA: 0x001C87B0 File Offset: 0x001C69B0
		// (set) Token: 0x06013678 RID: 79480 RVA: 0x001C87E9 File Offset: 0x001C69E9
		public TArray<string> StringChoiceLabels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StringChoiceLabels) == null)
				{
					result = (this._StringChoiceLabels = new TArray<string>(base.NativePtr + (IntPtr)UHoudiniParameterChoice.__PropertyOffset_StringChoiceLabels, this));
				}
				return result;
			}
			set
			{
				this.StringChoiceLabels.CopyAssign(value);
			}
		}

		// Token: 0x17004BBB RID: 19387
		// (get) Token: 0x06013679 RID: 79481 RVA: 0x001C87F7 File Offset: 0x001C69F7
		// (set) Token: 0x0601367A RID: 79482 RVA: 0x001C8807 File Offset: 0x001C6A07
		public unsafe bool bIsChildOfRamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterChoice.__PropertyOffset_bIsChildOfRamp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterChoice.__PropertyOffset_bIsChildOfRamp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BBC RID: 19388
		// (get) Token: 0x0601367B RID: 79483 RVA: 0x001C8818 File Offset: 0x001C6A18
		// (set) Token: 0x0601367C RID: 79484 RVA: 0x001C8851 File Offset: 0x001C6A51
		public TArray<int> IntValuesArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._IntValuesArray) == null)
				{
					result = (this._IntValuesArray = new TArray<int>(base.NativePtr + (IntPtr)UHoudiniParameterChoice.__PropertyOffset_IntValuesArray, this));
				}
				return result;
			}
			set
			{
				this.IntValuesArray.CopyAssign(value);
			}
		}

		// Token: 0x0601367D RID: 79485 RVA: 0x001C885F File Offset: 0x001C6A5F
		static UHoudiniParameterChoice()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterChoice");
		}

		// Token: 0x0601367E RID: 79486 RVA: 0x001C886D File Offset: 0x001C6A6D
		protected UHoudiniParameterChoice(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A7B7 RID: 42935
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterChoice";

		// Token: 0x0400A7B8 RID: 42936
		private static IntPtr _ClassPtr;

		// Token: 0x0400A7B9 RID: 42937
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A7BA RID: 42938
		internal static int __PropertyOffset_IntValue;

		// Token: 0x0400A7BB RID: 42939
		internal static int __PropertyOffset_DefaultIntValue;

		// Token: 0x0400A7BC RID: 42940
		internal static int __PropertyOffset_StringValue;

		// Token: 0x0400A7BD RID: 42941
		internal static int __PropertyOffset_DefaultStringValue;

		// Token: 0x0400A7BE RID: 42942
		internal static int __PropertyOffset_StringChoiceValues;

		// Token: 0x0400A7BF RID: 42943
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StringChoiceValues;

		// Token: 0x0400A7C0 RID: 42944
		internal static int __PropertyOffset_StringChoiceLabels;

		// Token: 0x0400A7C1 RID: 42945
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StringChoiceLabels;

		// Token: 0x0400A7C2 RID: 42946
		internal static int __PropertyOffset_bIsChildOfRamp;

		// Token: 0x0400A7C3 RID: 42947
		internal static int __PropertyOffset_IntValuesArray;

		// Token: 0x0400A7C4 RID: 42948
		[Nullable(2)]
		private TArray<int> _IntValuesArray;
	}
}
