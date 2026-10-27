using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024C3 RID: 9411
	[UnrealObjectPath("/Script/NetCore.NetAnalyticsDataConfig")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNetAnalyticsDataConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023373 RID: 144243 RVA: 0x00341786 File Offset: 0x0033F986
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNetAnalyticsDataConfig._ScriptStructPtr != 0) ? FNetAnalyticsDataConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NetCore.NetAnalyticsDataConfig", ref FNetAnalyticsDataConfig._ScriptStructPtr);
		}

		// Token: 0x17008765 RID: 34661
		// (get) Token: 0x06023374 RID: 144244 RVA: 0x003417AA File Offset: 0x0033F9AA
		// (set) Token: 0x06023375 RID: 144245 RVA: 0x003417BE File Offset: 0x0033F9BE
		public unsafe FName DataName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNetAnalyticsDataConfig.__PropertyOffset_DataName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNetAnalyticsDataConfig.__PropertyOffset_DataName) = value;
			}
		}

		// Token: 0x17008766 RID: 34662
		// (get) Token: 0x06023376 RID: 144246 RVA: 0x003417D3 File Offset: 0x0033F9D3
		// (set) Token: 0x06023377 RID: 144247 RVA: 0x003417E3 File Offset: 0x0033F9E3
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNetAnalyticsDataConfig.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNetAnalyticsDataConfig.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023378 RID: 144248 RVA: 0x003417F4 File Offset: 0x0033F9F4
		public FNetAnalyticsDataConfig()
		{
		}

		// Token: 0x06023379 RID: 144249 RVA: 0x003417FC File Offset: 0x0033F9FC
		public FNetAnalyticsDataConfig(FName DataName, bool bEnabled)
		{
			this.DataName = DataName;
			this.bEnabled = bEnabled;
		}

		// Token: 0x0602337A RID: 144250 RVA: 0x00341812 File Offset: 0x0033FA12
		protected override IntPtr GetUStructPtr()
		{
			return FNetAnalyticsDataConfig.StaticStruct();
		}

		// Token: 0x0602337B RID: 144251 RVA: 0x0034181E File Offset: 0x0033FA1E
		[NullableContext(2)]
		public FNetAnalyticsDataConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602337C RID: 144252 RVA: 0x00341828 File Offset: 0x0033FA28
		public FNetAnalyticsDataConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602337D RID: 144253 RVA: 0x00341833 File Offset: 0x0033FA33
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNetAnalyticsDataConfig(Pointer, false, true);
		}

		// Token: 0x0602337E RID: 144254 RVA: 0x0034183D File Offset: 0x0033FA3D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNetAnalyticsDataConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04012CF4 RID: 77044
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NetCore.NetAnalyticsDataConfig";

		// Token: 0x04012CF5 RID: 77045
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012CF6 RID: 77046
		internal static int __PropertyOffset_DataName;

		// Token: 0x04012CF7 RID: 77047
		internal static int __PropertyOffset_bEnabled;
	}
}
