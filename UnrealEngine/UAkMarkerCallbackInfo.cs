using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200021F RID: 543
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkMarkerCallbackInfo")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UAkMarkerCallbackInfo : UAkEventCallbackInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002017 RID: 8215 RVA: 0x0002F901 File Offset: 0x0002DB01
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkMarkerCallbackInfo._ClassPtr;
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x0002F910 File Offset: 0x0002DB10
		public UAkMarkerCallbackInfo() : this(BuiltinUtils.AllocNativeUObject(UAkMarkerCallbackInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x0002F938 File Offset: 0x0002DB38
		public UAkMarkerCallbackInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkMarkerCallbackInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x0002F96B File Offset: 0x0002DB6B
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x0002F97B File Offset: 0x0002DB7B
		public unsafe int Identifier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkMarkerCallbackInfo.__PropertyOffset_Identifier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkMarkerCallbackInfo.__PropertyOffset_Identifier) = value;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x0002F98C File Offset: 0x0002DB8C
		// (set) Token: 0x0600201D RID: 8221 RVA: 0x0002F99C File Offset: 0x0002DB9C
		public unsafe int Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkMarkerCallbackInfo.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkMarkerCallbackInfo.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x0002F9AD File Offset: 0x0002DBAD
		// (set) Token: 0x0600201F RID: 8223 RVA: 0x0002F9C1 File Offset: 0x0002DBC1
		public unsafe string Label
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAkMarkerCallbackInfo.__PropertyOffset_Label)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAkMarkerCallbackInfo.__PropertyOffset_Label)), value);
			}
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x0002F9D6 File Offset: 0x0002DBD6
		static UAkMarkerCallbackInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkMarkerCallbackInfo");
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x0002F9E4 File Offset: 0x0002DBE4
		protected UAkMarkerCallbackInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AB9 RID: 2745
		public new const string __ObjectPath = "/Script/AkAudio.AkMarkerCallbackInfo";

		// Token: 0x04000ABA RID: 2746
		private static IntPtr _ClassPtr;

		// Token: 0x04000ABB RID: 2747
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000ABC RID: 2748
		internal static int __PropertyOffset_Identifier;

		// Token: 0x04000ABD RID: 2749
		internal static int __PropertyOffset_Position;

		// Token: 0x04000ABE RID: 2750
		internal static int __PropertyOffset_Label;
	}
}
