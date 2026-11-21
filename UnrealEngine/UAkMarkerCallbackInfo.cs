using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000C5 RID: 197
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkMarkerCallbackInfo")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UAkMarkerCallbackInfo : UAkEventCallbackInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000EC3 RID: 3779 RVA: 0x00016DD9 File Offset: 0x00014FD9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkMarkerCallbackInfo._ClassPtr;
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00016DE8 File Offset: 0x00014FE8
		public UAkMarkerCallbackInfo() : this(BuiltinUtils.AllocNativeUObject(UAkMarkerCallbackInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00016E10 File Offset: 0x00015010
		public UAkMarkerCallbackInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkMarkerCallbackInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x00016E43 File Offset: 0x00015043
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x00016E53 File Offset: 0x00015053
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

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x00016E64 File Offset: 0x00015064
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x00016E74 File Offset: 0x00015074
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

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x00016E85 File Offset: 0x00015085
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x00016E99 File Offset: 0x00015099
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

		// Token: 0x06000ECC RID: 3788 RVA: 0x00016EAE File Offset: 0x000150AE
		static UAkMarkerCallbackInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkMarkerCallbackInfo");
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00016EBC File Offset: 0x000150BC
		protected UAkMarkerCallbackInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002DA RID: 730
		public new const string __ObjectPath = "/Script/AkAudio.AkMarkerCallbackInfo";

		// Token: 0x040002DB RID: 731
		private static IntPtr _ClassPtr;

		// Token: 0x040002DC RID: 732
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002DD RID: 733
		internal static int __PropertyOffset_Identifier;

		// Token: 0x040002DE RID: 734
		internal static int __PropertyOffset_Position;

		// Token: 0x040002DF RID: 735
		internal static int __PropertyOffset_Label;
	}
}
