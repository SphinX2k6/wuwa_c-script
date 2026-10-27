using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200228F RID: 8847
	[UnrealObjectPath("/Script/MediaAssets.BaseMediaSource")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public abstract class UBaseMediaSource : UMediaSource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060219F7 RID: 137719 RVA: 0x0031BE0B File Offset: 0x0031A00B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBaseMediaSource._ClassPtr;
		}

		// Token: 0x170082A2 RID: 33442
		// (get) Token: 0x060219F8 RID: 137720 RVA: 0x0031BE17 File Offset: 0x0031A017
		// (set) Token: 0x060219F9 RID: 137721 RVA: 0x0031BE2B File Offset: 0x0031A02B
		public unsafe FName PlayerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBaseMediaSource.__PropertyOffset_PlayerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBaseMediaSource.__PropertyOffset_PlayerName) = value;
			}
		}

		// Token: 0x060219FA RID: 137722 RVA: 0x0031BE40 File Offset: 0x0031A040
		static UBaseMediaSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.BaseMediaSource");
		}

		// Token: 0x060219FB RID: 137723 RVA: 0x0031BE50 File Offset: 0x0031A050
		protected UBaseMediaSource() : this(BuiltinUtils.AllocNativeUObject(UBaseMediaSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060219FC RID: 137724 RVA: 0x0031BE78 File Offset: 0x0031A078
		protected UBaseMediaSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F48 RID: 73544
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MediaAssets.BaseMediaSource";

		// Token: 0x04011F49 RID: 73545
		private static IntPtr _ClassPtr;

		// Token: 0x04011F4A RID: 73546
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F4B RID: 73547
		internal static int __PropertyOffset_PlayerName;
	}
}
