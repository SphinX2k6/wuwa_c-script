using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D9 RID: 985
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroActorStreamingHandle")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKuroActorStreamingHandle : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006101 RID: 24833 RVA: 0x0008AA16 File Offset: 0x00088C16
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroActorStreamingHandle._ClassPtr;
		}

		// Token: 0x06006102 RID: 24834 RVA: 0x0008AA24 File Offset: 0x00088C24
		public UKuroActorStreamingHandle() : this(BuiltinUtils.AllocNativeUObject(UKuroActorStreamingHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006103 RID: 24835 RVA: 0x0008AA4C File Offset: 0x00088C4C
		public UKuroActorStreamingHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroActorStreamingHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06006104 RID: 24836 RVA: 0x0008AA80 File Offset: 0x00088C80
		// (set) Token: 0x06006105 RID: 24837 RVA: 0x0008AAB9 File Offset: 0x00088CB9
		public FKuroActorStreamingCompleted OnCompleted
		{
			get
			{
				base.FastCheckIsValid();
				FKuroActorStreamingCompleted result;
				if ((result = this._OnCompleted) == null)
				{
					result = (this._OnCompleted = new FKuroActorStreamingCompleted(base.NativePtr + (IntPtr)UKuroActorStreamingHandle.__PropertyOffset_OnCompleted, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroActorStreamingHandle.__PropertyOffset_OnCompleted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06006106 RID: 24838 RVA: 0x0008AADA File Offset: 0x00088CDA
		public bool IsCompleted()
		{
			return UKuroActorStreamingHandle.__IsCompleted_Internal(base.NativePtr);
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x0008AAE7 File Offset: 0x00088CE7
		public bool IsCancelled()
		{
			return UKuroActorStreamingHandle.__IsCancelled_Internal(base.NativePtr);
		}

		// Token: 0x06006108 RID: 24840 RVA: 0x0008AAF4 File Offset: 0x00088CF4
		public int GetRequestedCount()
		{
			return UKuroActorStreamingHandle.__GetRequestedCount_Internal(base.NativePtr);
		}

		// Token: 0x06006109 RID: 24841 RVA: 0x0008AB01 File Offset: 0x00088D01
		public int GetLoadedCount()
		{
			return UKuroActorStreamingHandle.__GetLoadedCount_Internal(base.NativePtr);
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x0008AB0E File Offset: 0x00088D0E
		public void Cancel()
		{
			UKuroActorStreamingHandle.__Cancel_Internal(base.NativePtr);
		}

		// Token: 0x0600610B RID: 24843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCompleted_Internal(IntPtr @this);

		// Token: 0x0600610C RID: 24844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCancelled_Internal(IntPtr @this);

		// Token: 0x0600610D RID: 24845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRequestedCount_Internal(IntPtr @this);

		// Token: 0x0600610E RID: 24846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLoadedCount_Internal(IntPtr @this);

		// Token: 0x0600610F RID: 24847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Cancel_Internal(IntPtr @this);

		// Token: 0x06006110 RID: 24848 RVA: 0x0008AB1B File Offset: 0x00088D1B
		static UKuroActorStreamingHandle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroActorStreamingHandle");
		}

		// Token: 0x06006111 RID: 24849 RVA: 0x0008AB29 File Offset: 0x00088D29
		protected UKuroActorStreamingHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002958 RID: 10584
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroActorStreamingHandle";

		// Token: 0x04002959 RID: 10585
		private static IntPtr _ClassPtr;

		// Token: 0x0400295A RID: 10586
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400295B RID: 10587
		internal static int __PropertyOffset_OnCompleted;

		// Token: 0x0400295C RID: 10588
		[Nullable(2)]
		private FKuroActorStreamingCompleted _OnCompleted;
	}
}
