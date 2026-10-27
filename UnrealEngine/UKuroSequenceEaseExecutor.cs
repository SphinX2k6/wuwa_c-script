using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001909 RID: 6409
	[UnrealObjectPath("/Script/KuroGameplay.KuroSequenceEaseExecutor")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKuroSequenceEaseExecutor : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017C7F RID: 97407 RVA: 0x0022D710 File Offset: 0x0022B910
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSequenceEaseExecutor._ClassPtr;
		}

		// Token: 0x06017C80 RID: 97408 RVA: 0x0022D71C File Offset: 0x0022B91C
		public UKuroSequenceEaseExecutor() : this(BuiltinUtils.AllocNativeUObject(UKuroSequenceEaseExecutor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017C81 RID: 97409 RVA: 0x0022D744 File Offset: 0x0022B944
		[NullableContext(1)]
		public UKuroSequenceEaseExecutor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSequenceEaseExecutor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017C82 RID: 97410 RVA: 0x0022D777 File Offset: 0x0022B977
		public bool UpdateEase(float DeltaTime)
		{
			return UKuroSequenceEaseExecutor.__UpdateEase_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06017C83 RID: 97411 RVA: 0x0022D785 File Offset: 0x0022B985
		public void StopEase()
		{
			UKuroSequenceEaseExecutor.__StopEase_Internal(base.NativePtr);
		}

		// Token: 0x06017C84 RID: 97412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UpdateEase_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06017C85 RID: 97413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopEase_Internal(IntPtr @this);

		// Token: 0x06017C86 RID: 97414 RVA: 0x0022D792 File Offset: 0x0022B992
		static UKuroSequenceEaseExecutor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroSequenceEaseExecutor");
		}

		// Token: 0x06017C87 RID: 97415 RVA: 0x0022D7A0 File Offset: 0x0022B9A0
		protected UKuroSequenceEaseExecutor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE62 RID: 52834
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroSequenceEaseExecutor";

		// Token: 0x0400CE63 RID: 52835
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE64 RID: 52836
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
