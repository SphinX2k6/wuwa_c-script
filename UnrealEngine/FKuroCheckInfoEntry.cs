using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000442 RID: 1090
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroHotPatch.KuroCheckInfoEntry")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroCheckInfoEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006935 RID: 26933 RVA: 0x00099BAF File Offset: 0x00097DAF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCheckInfoEntry._ScriptStructPtr != 0) ? FKuroCheckInfoEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroHotPatch.KuroCheckInfoEntry", ref FKuroCheckInfoEntry._ScriptStructPtr);
		}

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x06006936 RID: 26934 RVA: 0x00099BD3 File Offset: 0x00097DD3
		// (set) Token: 0x06006937 RID: 26935 RVA: 0x00099BE7 File Offset: 0x00097DE7
		public unsafe string FileName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_FileName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_FileName)), value);
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06006938 RID: 26936 RVA: 0x00099BFC File Offset: 0x00097DFC
		// (set) Token: 0x06006939 RID: 26937 RVA: 0x00099C10 File Offset: 0x00097E10
		public unsafe string FilePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_FilePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_FilePath)), value);
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x0600693A RID: 26938 RVA: 0x00099C25 File Offset: 0x00097E25
		// (set) Token: 0x0600693B RID: 26939 RVA: 0x00099C39 File Offset: 0x00097E39
		public unsafe string Hash
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Hash)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Hash)), value);
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x0600693C RID: 26940 RVA: 0x00099C4E File Offset: 0x00097E4E
		// (set) Token: 0x0600693D RID: 26941 RVA: 0x00099C5E File Offset: 0x00097E5E
		public unsafe long Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x0600693E RID: 26942 RVA: 0x00099C6F File Offset: 0x00097E6F
		// (set) Token: 0x0600693F RID: 26943 RVA: 0x00099C83 File Offset: 0x00097E83
		public unsafe string Url
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Url)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Url)), value);
			}
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x06006940 RID: 26944 RVA: 0x00099C98 File Offset: 0x00097E98
		// (set) Token: 0x06006941 RID: 26945 RVA: 0x00099CA8 File Offset: 0x00097EA8
		public unsafe bool NeedRestart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCheckInfoEntry.__PropertyOffset_NeedRestart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCheckInfoEntry.__PropertyOffset_NeedRestart) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06006942 RID: 26946 RVA: 0x00099CB9 File Offset: 0x00097EB9
		// (set) Token: 0x06006943 RID: 26947 RVA: 0x00099CC9 File Offset: 0x00097EC9
		public unsafe int Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x00099CDA File Offset: 0x00097EDA
		public FKuroCheckInfoEntry()
		{
		}

		// Token: 0x06006945 RID: 26949 RVA: 0x00099CE2 File Offset: 0x00097EE2
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCheckInfoEntry.StaticStruct();
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x00099CEE File Offset: 0x00097EEE
		[NullableContext(2)]
		public FKuroCheckInfoEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x00099CF8 File Offset: 0x00097EF8
		public FKuroCheckInfoEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x00099D03 File Offset: 0x00097F03
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCheckInfoEntry(Pointer, false, true);
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x00099D0D File Offset: 0x00097F0D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCheckInfoEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04002CD9 RID: 11481
		public const string __ObjectPath = "/Script/KuroHotPatch.KuroCheckInfoEntry";

		// Token: 0x04002CDA RID: 11482
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002CDB RID: 11483
		internal static int __PropertyOffset_FileName;

		// Token: 0x04002CDC RID: 11484
		internal static int __PropertyOffset_FilePath;

		// Token: 0x04002CDD RID: 11485
		internal static int __PropertyOffset_Hash;

		// Token: 0x04002CDE RID: 11486
		internal static int __PropertyOffset_Size;

		// Token: 0x04002CDF RID: 11487
		internal static int __PropertyOffset_Url;

		// Token: 0x04002CE0 RID: 11488
		internal static int __PropertyOffset_NeedRestart;

		// Token: 0x04002CE1 RID: 11489
		internal static int __PropertyOffset_Result;
	}
}
