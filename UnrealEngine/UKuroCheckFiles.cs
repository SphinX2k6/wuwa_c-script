using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000441 RID: 1089
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroHotPatch.KuroCheckFiles")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKuroCheckFiles : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006924 RID: 26916 RVA: 0x000999EE File Offset: 0x00097BEE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCheckFiles._ClassPtr;
		}

		// Token: 0x06006925 RID: 26917 RVA: 0x000999FC File Offset: 0x00097BFC
		public UKuroCheckFiles() : this(BuiltinUtils.AllocNativeUObject(UKuroCheckFiles.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006926 RID: 26918 RVA: 0x00099A24 File Offset: 0x00097C24
		public UKuroCheckFiles(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCheckFiles.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x06006927 RID: 26919 RVA: 0x00099A58 File Offset: 0x00097C58
		// (set) Token: 0x06006928 RID: 26920 RVA: 0x00099A91 File Offset: 0x00097C91
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

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x06006929 RID: 26921 RVA: 0x00099A9F File Offset: 0x00097C9F
		// (set) Token: 0x0600692A RID: 26922 RVA: 0x00099AB3 File Offset: 0x00097CB3
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

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x0600692B RID: 26923 RVA: 0x00099AC8 File Offset: 0x00097CC8
		// (set) Token: 0x0600692C RID: 26924 RVA: 0x00099B01 File Offset: 0x00097D01
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

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x0600692D RID: 26925 RVA: 0x00099B24 File Offset: 0x00097D24
		// (set) Token: 0x0600692E RID: 26926 RVA: 0x00099B5D File Offset: 0x00097D5D
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

		// Token: 0x0600692F RID: 26927 RVA: 0x00099B7E File Offset: 0x00097D7E
		public void Clear()
		{
			UKuroCheckFiles.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x06006930 RID: 26928 RVA: 0x00099B8B File Offset: 0x00097D8B
		public void Check()
		{
			UKuroCheckFiles.__Check_Internal(base.NativePtr);
		}

		// Token: 0x06006931 RID: 26929
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x06006932 RID: 26930
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Check_Internal(IntPtr @this);

		// Token: 0x06006933 RID: 26931 RVA: 0x00099B98 File Offset: 0x00097D98
		static UKuroCheckFiles()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroHotPatch.KuroCheckFiles");
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x00099BA6 File Offset: 0x00097DA6
		protected UKuroCheckFiles(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002CCF RID: 11471
		public new const string __ObjectPath = "/Script/KuroHotPatch.KuroCheckFiles";

		// Token: 0x04002CD0 RID: 11472
		private static IntPtr _ClassPtr;

		// Token: 0x04002CD1 RID: 11473
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002CD2 RID: 11474
		internal static int __PropertyOffset_CheckList;

		// Token: 0x04002CD3 RID: 11475
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCheckInfoEntry> _CheckList;

		// Token: 0x04002CD4 RID: 11476
		internal static int __PropertyOffset_TmpSuffix;

		// Token: 0x04002CD5 RID: 11477
		internal static int __PropertyOffset_ProgressDelegate;

		// Token: 0x04002CD6 RID: 11478
		[Nullable(2)]
		private FKuroCheckProgress _ProgressDelegate;

		// Token: 0x04002CD7 RID: 11479
		internal static int __PropertyOffset_CompleteDelegate;

		// Token: 0x04002CD8 RID: 11480
		[Nullable(2)]
		private FKuroCheckComplete _CompleteDelegate;
	}
}
