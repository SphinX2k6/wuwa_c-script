using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014FC RID: 5372
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterToggle")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UHoudiniParameterToggle : UHoudiniParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601378B RID: 79755 RVA: 0x001CA0B3 File Offset: 0x001C82B3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterToggle._ClassPtr;
		}

		// Token: 0x0601378C RID: 79756 RVA: 0x001CA0C0 File Offset: 0x001C82C0
		public UHoudiniParameterToggle() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterToggle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601378D RID: 79757 RVA: 0x001CA0E8 File Offset: 0x001C82E8
		public UHoudiniParameterToggle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterToggle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C1B RID: 19483
		// (get) Token: 0x0601378E RID: 79758 RVA: 0x001CA11C File Offset: 0x001C831C
		// (set) Token: 0x0601378F RID: 79759 RVA: 0x001CA155 File Offset: 0x001C8355
		public TArray<int> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<int>(base.NativePtr + (IntPtr)UHoudiniParameterToggle.__PropertyOffset_Values, this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x17004C1C RID: 19484
		// (get) Token: 0x06013790 RID: 79760 RVA: 0x001CA164 File Offset: 0x001C8364
		// (set) Token: 0x06013791 RID: 79761 RVA: 0x001CA19D File Offset: 0x001C839D
		public TArray<int> DefaultValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._DefaultValues) == null)
				{
					result = (this._DefaultValues = new TArray<int>(base.NativePtr + (IntPtr)UHoudiniParameterToggle.__PropertyOffset_DefaultValues, this));
				}
				return result;
			}
			set
			{
				this.DefaultValues.CopyAssign(value);
			}
		}

		// Token: 0x06013792 RID: 79762 RVA: 0x001CA1AB File Offset: 0x001C83AB
		static UHoudiniParameterToggle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterToggle");
		}

		// Token: 0x06013793 RID: 79763 RVA: 0x001CA1B9 File Offset: 0x001C83B9
		protected UHoudiniParameterToggle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A86B RID: 43115
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterToggle";

		// Token: 0x0400A86C RID: 43116
		private static IntPtr _ClassPtr;

		// Token: 0x0400A86D RID: 43117
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A86E RID: 43118
		internal static int __PropertyOffset_Values;

		// Token: 0x0400A86F RID: 43119
		[Nullable(2)]
		private TArray<int> _Values;

		// Token: 0x0400A870 RID: 43120
		internal static int __PropertyOffset_DefaultValues;

		// Token: 0x0400A871 RID: 43121
		[Nullable(2)]
		private TArray<int> _DefaultValues;
	}
}
