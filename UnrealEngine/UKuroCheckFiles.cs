using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001985 RID: 6533
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroHotPatch.KuroCheckFiles")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKuroCheckFiles : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018436 RID: 99382 RVA: 0x0023CA82 File Offset: 0x0023AC82
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCheckFiles._ClassPtr;
		}

		// Token: 0x06018437 RID: 99383 RVA: 0x0023CA90 File Offset: 0x0023AC90
		public UKuroCheckFiles() : this(BuiltinUtils.AllocNativeUObject(UKuroCheckFiles.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018438 RID: 99384 RVA: 0x0023CAB8 File Offset: 0x0023ACB8
		public UKuroCheckFiles(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCheckFiles.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006104 RID: 24836
		// (get) Token: 0x06018439 RID: 99385 RVA: 0x0023CAEC File Offset: 0x0023ACEC
		// (set) Token: 0x0601843A RID: 99386 RVA: 0x0023CB25 File Offset: 0x0023AD25
		public TArray<FKuroCheckInfoEntry> CheckList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCheckInfoEntry> result;
				if ((result = this._CheckList) == null)
				{
					result = (this._CheckList = new TArray<FKuroCheckInfoEntry>(base.NativePtr + (IntPtr)UKuroCheckFiles.__PropertyOffset_CheckList, this));
				}
				return result;
			}
			set
			{
				this.CheckList.CopyAssign(value);
			}
		}

		// Token: 0x17006105 RID: 24837
		// (get) Token: 0x0601843B RID: 99387 RVA: 0x0023CB33 File Offset: 0x0023AD33
		// (set) Token: 0x0601843C RID: 99388 RVA: 0x0023CB47 File Offset: 0x0023AD47
		public unsafe string TmpSuffix
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroCheckFiles.__PropertyOffset_TmpSuffix)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroCheckFiles.__PropertyOffset_TmpSuffix)), value);
			}
		}

		// Token: 0x17006106 RID: 24838
		// (get) Token: 0x0601843D RID: 99389 RVA: 0x0023CB5C File Offset: 0x0023AD5C
		// (set) Token: 0x0601843E RID: 99390 RVA: 0x0023CB95 File Offset: 0x0023AD95
		public FKuroCheckProgress ProgressDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCheckProgress result;
				if ((result = this._ProgressDelegate) == null)
				{
					result = (this._ProgressDelegate = new FKuroCheckProgress(base.NativePtr + (IntPtr)UKuroCheckFiles.__PropertyOffset_ProgressDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroCheckFiles.__PropertyOffset_ProgressDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006107 RID: 24839
		// (get) Token: 0x0601843F RID: 99391 RVA: 0x0023CBB8 File Offset: 0x0023ADB8
		// (set) Token: 0x06018440 RID: 99392 RVA: 0x0023CBF1 File Offset: 0x0023ADF1
		public FKuroCheckComplete CompleteDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCheckComplete result;
				if ((result = this._CompleteDelegate) == null)
				{
					result = (this._CompleteDelegate = new FKuroCheckComplete(base.NativePtr + (IntPtr)UKuroCheckFiles.__PropertyOffset_CompleteDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroCheckFiles.__PropertyOffset_CompleteDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06018441 RID: 99393 RVA: 0x0023CC12 File Offset: 0x0023AE12
		public void Clear()
		{
			UKuroCheckFiles.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x06018442 RID: 99394 RVA: 0x0023CC1F File Offset: 0x0023AE1F
		public void Check()
		{
			UKuroCheckFiles.__Check_Internal(base.NativePtr);
		}

		// Token: 0x06018443 RID: 99395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x06018444 RID: 99396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Check_Internal(IntPtr @this);

		// Token: 0x06018445 RID: 99397 RVA: 0x0023CC2C File Offset: 0x0023AE2C
		static UKuroCheckFiles()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroHotPatch.KuroCheckFiles");
		}

		// Token: 0x06018446 RID: 99398 RVA: 0x0023CC3A File Offset: 0x0023AE3A
		protected UKuroCheckFiles(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D23B RID: 53819
		public new const string __ObjectPath = "/Script/KuroHotPatch.KuroCheckFiles";

		// Token: 0x0400D23C RID: 53820
		private static IntPtr _ClassPtr;

		// Token: 0x0400D23D RID: 53821
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D23E RID: 53822
		internal static int __PropertyOffset_CheckList;

		// Token: 0x0400D23F RID: 53823
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCheckInfoEntry> _CheckList;

		// Token: 0x0400D240 RID: 53824
		internal static int __PropertyOffset_TmpSuffix;

		// Token: 0x0400D241 RID: 53825
		internal static int __PropertyOffset_ProgressDelegate;

		// Token: 0x0400D242 RID: 53826
		[Nullable(2)]
		private FKuroCheckProgress _ProgressDelegate;

		// Token: 0x0400D243 RID: 53827
		internal static int __PropertyOffset_CompleteDelegate;

		// Token: 0x0400D244 RID: 53828
		[Nullable(2)]
		private FKuroCheckComplete _CompleteDelegate;
	}
}
