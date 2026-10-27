using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001B1 RID: 433
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryTest_Project")]
	[UnrealStructLayout(656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class UEnvQueryTest_Project : UEnvQueryTest, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001A75 RID: 6773 RVA: 0x00027561 File Offset: 0x00025761
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryTest_Project._ClassPtr;
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x00027570 File Offset: 0x00025770
		public UEnvQueryTest_Project() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Project.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x00027598 File Offset: 0x00025798
		public UEnvQueryTest_Project(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Project.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x000275CC File Offset: 0x000257CC
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x00027605 File Offset: 0x00025805
		public FEnvTraceData ProjectionData
		{
			get
			{
				base.FastCheckIsValid();
				FEnvTraceData result;
				if ((result = this._ProjectionData) == null)
				{
					result = (this._ProjectionData = new FEnvTraceData(base.NativePtr + (IntPtr)UEnvQueryTest_Project.__PropertyOffset_ProjectionData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEnvTraceData.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest_Project.__PropertyOffset_ProjectionData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00027626 File Offset: 0x00025826
		static UEnvQueryTest_Project()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryTest_Project");
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00027634 File Offset: 0x00025834
		protected UEnvQueryTest_Project(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000804 RID: 2052
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryTest_Project";

		// Token: 0x04000805 RID: 2053
		private static IntPtr _ClassPtr;

		// Token: 0x04000806 RID: 2054
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000807 RID: 2055
		internal static int __PropertyOffset_ProjectionData;

		// Token: 0x04000808 RID: 2056
		[Nullable(2)]
		private FEnvTraceData _ProjectionData;
	}
}
