using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014FB RID: 5371
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterString")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UHoudiniParameterString : UHoudiniParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601377E RID: 79742 RVA: 0x001C9F3A File Offset: 0x001C813A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterString._ClassPtr;
		}

		// Token: 0x0601377F RID: 79743 RVA: 0x001C9F48 File Offset: 0x001C8148
		public UHoudiniParameterString() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterString.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013780 RID: 79744 RVA: 0x001C9F70 File Offset: 0x001C8170
		public UHoudiniParameterString(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterString.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C17 RID: 19479
		// (get) Token: 0x06013781 RID: 79745 RVA: 0x001C9FA4 File Offset: 0x001C81A4
		// (set) Token: 0x06013782 RID: 79746 RVA: 0x001C9FDD File Offset: 0x001C81DD
		public TArray<string> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<string>(base.NativePtr + (IntPtr)UHoudiniParameterString.__PropertyOffset_Values, this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x17004C18 RID: 19480
		// (get) Token: 0x06013783 RID: 79747 RVA: 0x001C9FEC File Offset: 0x001C81EC
		// (set) Token: 0x06013784 RID: 79748 RVA: 0x001CA025 File Offset: 0x001C8225
		public TArray<string> DefaultValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._DefaultValues) == null)
				{
					result = (this._DefaultValues = new TArray<string>(base.NativePtr + (IntPtr)UHoudiniParameterString.__PropertyOffset_DefaultValues, this));
				}
				return result;
			}
			set
			{
				this.DefaultValues.CopyAssign(value);
			}
		}

		// Token: 0x17004C19 RID: 19481
		// (get) Token: 0x06013785 RID: 79749 RVA: 0x001CA034 File Offset: 0x001C8234
		// (set) Token: 0x06013786 RID: 79750 RVA: 0x001CA06D File Offset: 0x001C826D
		public TArray<UObject> ChosenAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ChosenAssets) == null)
				{
					result = (this._ChosenAssets = new TArray<UObject>(base.NativePtr + (IntPtr)UHoudiniParameterString.__PropertyOffset_ChosenAssets, this));
				}
				return result;
			}
			set
			{
				this.ChosenAssets.CopyAssign(value);
			}
		}

		// Token: 0x17004C1A RID: 19482
		// (get) Token: 0x06013787 RID: 79751 RVA: 0x001CA07B File Offset: 0x001C827B
		// (set) Token: 0x06013788 RID: 79752 RVA: 0x001CA08B File Offset: 0x001C828B
		public unsafe bool bIsAssetRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterString.__PropertyOffset_bIsAssetRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterString.__PropertyOffset_bIsAssetRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013789 RID: 79753 RVA: 0x001CA09C File Offset: 0x001C829C
		static UHoudiniParameterString()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterString");
		}

		// Token: 0x0601378A RID: 79754 RVA: 0x001CA0AA File Offset: 0x001C82AA
		protected UHoudiniParameterString(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A861 RID: 43105
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterString";

		// Token: 0x0400A862 RID: 43106
		private static IntPtr _ClassPtr;

		// Token: 0x0400A863 RID: 43107
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A864 RID: 43108
		internal static int __PropertyOffset_Values;

		// Token: 0x0400A865 RID: 43109
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Values;

		// Token: 0x0400A866 RID: 43110
		internal static int __PropertyOffset_DefaultValues;

		// Token: 0x0400A867 RID: 43111
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _DefaultValues;

		// Token: 0x0400A868 RID: 43112
		internal static int __PropertyOffset_ChosenAssets;

		// Token: 0x0400A869 RID: 43113
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ChosenAssets;

		// Token: 0x0400A86A RID: 43114
		internal static int __PropertyOffset_bIsAssetRef;
	}
}
