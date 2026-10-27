using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008E2 RID: 2274
	[UnrealObjectPath("/Script/Engine.BookmarkBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UBookmarkBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007CD9 RID: 31961 RVA: 0x000B3089 File Offset: 0x000B1289
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBookmarkBase._ClassPtr;
		}

		// Token: 0x06007CDA RID: 31962 RVA: 0x000B3095 File Offset: 0x000B1295
		static UBookmarkBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BookmarkBase");
		}

		// Token: 0x06007CDB RID: 31963 RVA: 0x000B30A4 File Offset: 0x000B12A4
		protected UBookmarkBase() : this(BuiltinUtils.AllocNativeUObject(UBookmarkBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007CDC RID: 31964 RVA: 0x000B30CC File Offset: 0x000B12CC
		protected UBookmarkBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003BD8 RID: 15320
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BookmarkBase";

		// Token: 0x04003BD9 RID: 15321
		private static IntPtr _ClassPtr;

		// Token: 0x04003BDA RID: 15322
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
