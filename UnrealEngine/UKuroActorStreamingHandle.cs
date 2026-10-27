using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018BB RID: 6331
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroActorStreamingHandle")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKuroActorStreamingHandle : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601766E RID: 95854 RVA: 0x00223836 File Offset: 0x00221A36
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroActorStreamingHandle._ClassPtr;
		}

		// Token: 0x0601766F RID: 95855 RVA: 0x00223844 File Offset: 0x00221A44
		public UKuroActorStreamingHandle() : this(BuiltinUtils.AllocNativeUObject(UKuroActorStreamingHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017670 RID: 95856 RVA: 0x0022386C File Offset: 0x00221A6C
		public UKuroActorStreamingHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroActorStreamingHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005E8A RID: 24202
		// (get) Token: 0x06017671 RID: 95857 RVA: 0x002238A0 File Offset: 0x00221AA0
		// (set) Token: 0x06017672 RID: 95858 RVA: 0x002238D9 File Offset: 0x00221AD9
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

		// Token: 0x06017673 RID: 95859 RVA: 0x002238FA File Offset: 0x00221AFA
		public bool IsCompleted()
		{
			return UKuroActorStreamingHandle.__IsCompleted_Internal(base.NativePtr);
		}

		// Token: 0x06017674 RID: 95860 RVA: 0x00223907 File Offset: 0x00221B07
		public bool IsCancelled()
		{
			return UKuroActorStreamingHandle.__IsCancelled_Internal(base.NativePtr);
		}

		// Token: 0x06017675 RID: 95861 RVA: 0x00223914 File Offset: 0x00221B14
		public int GetRequestedCount()
		{
			return UKuroActorStreamingHandle.__GetRequestedCount_Internal(base.NativePtr);
		}

		// Token: 0x06017676 RID: 95862 RVA: 0x00223921 File Offset: 0x00221B21
		public int GetLoadedCount()
		{
			return UKuroActorStreamingHandle.__GetLoadedCount_Internal(base.NativePtr);
		}

		// Token: 0x06017677 RID: 95863 RVA: 0x0022392E File Offset: 0x00221B2E
		public void Cancel()
		{
			UKuroActorStreamingHandle.__Cancel_Internal(base.NativePtr);
		}

		// Token: 0x06017678 RID: 95864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCompleted_Internal(IntPtr @this);

		// Token: 0x06017679 RID: 95865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCancelled_Internal(IntPtr @this);

		// Token: 0x0601767A RID: 95866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRequestedCount_Internal(IntPtr @this);

		// Token: 0x0601767B RID: 95867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLoadedCount_Internal(IntPtr @this);

		// Token: 0x0601767C RID: 95868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Cancel_Internal(IntPtr @this);

		// Token: 0x0601767D RID: 95869 RVA: 0x0022393B File Offset: 0x00221B3B
		static UKuroActorStreamingHandle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroActorStreamingHandle");
		}

		// Token: 0x0601767E RID: 95870 RVA: 0x00223949 File Offset: 0x00221B49
		protected UKuroActorStreamingHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CBAC RID: 52140
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroActorStreamingHandle";

		// Token: 0x0400CBAD RID: 52141
		private static IntPtr _ClassPtr;

		// Token: 0x0400CBAE RID: 52142
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CBAF RID: 52143
		internal static int __PropertyOffset_OnCompleted;

		// Token: 0x0400CBB0 RID: 52144
		[Nullable(2)]
		private FKuroActorStreamingCompleted _OnCompleted;
	}
}
