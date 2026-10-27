using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002890 RID: 10384
	[UnrealObjectPath("/Script/SMSystem.SMRuntimeSettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class USMRuntimeSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602677F RID: 157567 RVA: 0x003A9194 File Offset: 0x003A7394
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMRuntimeSettings._ClassPtr;
		}

		// Token: 0x06026780 RID: 157568 RVA: 0x003A91A0 File Offset: 0x003A73A0
		public USMRuntimeSettings() : this(BuiltinUtils.AllocNativeUObject(USMRuntimeSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026781 RID: 157569 RVA: 0x003A91C8 File Offset: 0x003A73C8
		[NullableContext(1)]
		public USMRuntimeSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USMRuntimeSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700944D RID: 37965
		// (get) Token: 0x06026782 RID: 157570 RVA: 0x003A91FB File Offset: 0x003A73FB
		// (set) Token: 0x06026783 RID: 157571 RVA: 0x003A920B File Offset: 0x003A740B
		public unsafe bool bPreloadDefaultNodes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMRuntimeSettings.__PropertyOffset_bPreloadDefaultNodes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMRuntimeSettings.__PropertyOffset_bPreloadDefaultNodes) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026784 RID: 157572 RVA: 0x003A921C File Offset: 0x003A741C
		static USMRuntimeSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMRuntimeSettings");
		}

		// Token: 0x06026785 RID: 157573 RVA: 0x003A922A File Offset: 0x003A742A
		protected USMRuntimeSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040151C8 RID: 86472
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMRuntimeSettings";

		// Token: 0x040151C9 RID: 86473
		private static IntPtr _ClassPtr;

		// Token: 0x040151CA RID: 86474
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040151CB RID: 86475
		internal static int __PropertyOffset_bPreloadDefaultNodes;
	}
}
