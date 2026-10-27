using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002219 RID: 8729
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkSourceSettings")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class ULiveLinkSourceSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060213F0 RID: 136176 RVA: 0x00310263 File Offset: 0x0030E463
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkSourceSettings._ClassPtr;
		}

		// Token: 0x060213F1 RID: 136177 RVA: 0x00310270 File Offset: 0x0030E470
		public ULiveLinkSourceSettings() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkSourceSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060213F2 RID: 136178 RVA: 0x00310298 File Offset: 0x0030E498
		public ULiveLinkSourceSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULiveLinkSourceSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170081C5 RID: 33221
		// (get) Token: 0x060213F3 RID: 136179 RVA: 0x003102CB File Offset: 0x0030E4CB
		// (set) Token: 0x060213F4 RID: 136180 RVA: 0x003102DB File Offset: 0x0030E4DB
		public unsafe ELiveLinkSourceMode Mode
		{
			get
			{
				return (ELiveLinkSourceMode)(*(base.NativePtr + (IntPtr)ULiveLinkSourceSettings.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULiveLinkSourceSettings.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x170081C6 RID: 33222
		// (get) Token: 0x060213F5 RID: 136181 RVA: 0x003102EC File Offset: 0x0030E4EC
		// (set) Token: 0x060213F6 RID: 136182 RVA: 0x00310325 File Offset: 0x0030E525
		public FLiveLinkSourceBufferManagementSettings BufferSettings
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkSourceBufferManagementSettings result;
				if ((result = this._BufferSettings) == null)
				{
					result = (this._BufferSettings = new FLiveLinkSourceBufferManagementSettings(base.NativePtr + (IntPtr)ULiveLinkSourceSettings.__PropertyOffset_BufferSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkSourceBufferManagementSettings.StaticStruct(), base.NativePtr + (IntPtr)ULiveLinkSourceSettings.__PropertyOffset_BufferSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170081C7 RID: 33223
		// (get) Token: 0x060213F7 RID: 136183 RVA: 0x00310346 File Offset: 0x0030E546
		// (set) Token: 0x060213F8 RID: 136184 RVA: 0x0031035A File Offset: 0x0030E55A
		public unsafe string ConnectionString
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)ULiveLinkSourceSettings.__PropertyOffset_ConnectionString)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)ULiveLinkSourceSettings.__PropertyOffset_ConnectionString)), value);
			}
		}

		// Token: 0x170081C8 RID: 33224
		// (get) Token: 0x060213F9 RID: 136185 RVA: 0x0031036F File Offset: 0x0030E56F
		// (set) Token: 0x060213FA RID: 136186 RVA: 0x00310383 File Offset: 0x0030E583
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<ULiveLinkSourceFactory> Factory
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ULiveLinkSourceSettings.__PropertyOffset_Factory);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ULiveLinkSourceSettings.__PropertyOffset_Factory) = value;
			}
		}

		// Token: 0x060213FB RID: 136187 RVA: 0x00310398 File Offset: 0x0030E598
		static ULiveLinkSourceSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkSourceSettings");
		}

		// Token: 0x060213FC RID: 136188 RVA: 0x003103A6 File Offset: 0x0030E5A6
		protected ULiveLinkSourceSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011BBC RID: 72636
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkSourceSettings";

		// Token: 0x04011BBD RID: 72637
		private static IntPtr _ClassPtr;

		// Token: 0x04011BBE RID: 72638
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011BBF RID: 72639
		internal static int __PropertyOffset_Mode;

		// Token: 0x04011BC0 RID: 72640
		internal static int __PropertyOffset_BufferSettings;

		// Token: 0x04011BC1 RID: 72641
		[Nullable(2)]
		private FLiveLinkSourceBufferManagementSettings _BufferSettings;

		// Token: 0x04011BC2 RID: 72642
		internal static int __PropertyOffset_ConnectionString;

		// Token: 0x04011BC3 RID: 72643
		internal static int __PropertyOffset_Factory;
	}
}
