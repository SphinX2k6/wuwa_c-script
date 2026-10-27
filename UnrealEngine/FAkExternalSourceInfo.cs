using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000204 RID: 516
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkExternalSourceInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAkExternalSourceInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001E4C RID: 7756 RVA: 0x0002CECE File Offset: 0x0002B0CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkExternalSourceInfo._ScriptStructPtr != 0) ? FAkExternalSourceInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkExternalSourceInfo", ref FAkExternalSourceInfo._ScriptStructPtr);
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001E4D RID: 7757 RVA: 0x0002CEF2 File Offset: 0x0002B0F2
		// (set) Token: 0x06001E4E RID: 7758 RVA: 0x0002CF06 File Offset: 0x0002B106
		public unsafe string ExternalSrcName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAkExternalSourceInfo.__PropertyOffset_ExternalSrcName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAkExternalSourceInfo.__PropertyOffset_ExternalSrcName)), value);
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x0002CF1B File Offset: 0x0002B11B
		// (set) Token: 0x06001E50 RID: 7760 RVA: 0x0002CF2B File Offset: 0x0002B12B
		public unsafe EAkCodecId CodecID
		{
			get
			{
				return (EAkCodecId)(*(base.NativePtr + (IntPtr)FAkExternalSourceInfo.__PropertyOffset_CodecID));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkExternalSourceInfo.__PropertyOffset_CodecID) = (byte)value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001E51 RID: 7761 RVA: 0x0002CF3C File Offset: 0x0002B13C
		// (set) Token: 0x06001E52 RID: 7762 RVA: 0x0002CF50 File Offset: 0x0002B150
		public unsafe string FileName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAkExternalSourceInfo.__PropertyOffset_FileName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAkExternalSourceInfo.__PropertyOffset_FileName)), value);
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001E53 RID: 7763 RVA: 0x0002CF65 File Offset: 0x0002B165
		// (set) Token: 0x06001E54 RID: 7764 RVA: 0x0002CF79 File Offset: 0x0002B179
		[Nullable(2)]
		public unsafe UAkExternalMediaAsset ExternalSourceAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkExternalMediaAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FAkExternalSourceInfo.__PropertyOffset_ExternalSourceAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAkExternalSourceInfo.__PropertyOffset_ExternalSourceAsset, value);
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x0002CF8E File Offset: 0x0002B18E
		// (set) Token: 0x06001E56 RID: 7766 RVA: 0x0002CF9E File Offset: 0x0002B19E
		public unsafe bool IsStreamed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkExternalSourceInfo.__PropertyOffset_IsStreamed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkExternalSourceInfo.__PropertyOffset_IsStreamed) = (value ? 1 : 0);
			}
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x0002CFAF File Offset: 0x0002B1AF
		public FAkExternalSourceInfo()
		{
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x0002CFB7 File Offset: 0x0002B1B7
		public FAkExternalSourceInfo(string ExternalSrcName, EAkCodecId CodecID, string FileName, UAkExternalMediaAsset ExternalSourceAsset, bool IsStreamed)
		{
			this.ExternalSrcName = ExternalSrcName;
			this.CodecID = CodecID;
			this.FileName = FileName;
			this.ExternalSourceAsset = ExternalSourceAsset;
			this.IsStreamed = IsStreamed;
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x0002CFE4 File Offset: 0x0002B1E4
		protected override IntPtr GetUStructPtr()
		{
			return FAkExternalSourceInfo.StaticStruct();
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x0002CFF0 File Offset: 0x0002B1F0
		[NullableContext(2)]
		public FAkExternalSourceInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x0002CFFA File Offset: 0x0002B1FA
		public FAkExternalSourceInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x0002D005 File Offset: 0x0002B205
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkExternalSourceInfo(Pointer, false, true);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x0002D00F File Offset: 0x0002B20F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkExternalSourceInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04000A11 RID: 2577
		public const string __ObjectPath = "/Script/AkAudio.AkExternalSourceInfo";

		// Token: 0x04000A12 RID: 2578
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000A13 RID: 2579
		internal static int __PropertyOffset_ExternalSrcName;

		// Token: 0x04000A14 RID: 2580
		internal static int __PropertyOffset_CodecID;

		// Token: 0x04000A15 RID: 2581
		internal static int __PropertyOffset_FileName;

		// Token: 0x04000A16 RID: 2582
		internal static int __PropertyOffset_ExternalSourceAsset;

		// Token: 0x04000A17 RID: 2583
		internal static int __PropertyOffset_IsStreamed;
	}
}
