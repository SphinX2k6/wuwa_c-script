using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200044D RID: 1101
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ChaosSolverEngine.ChaosGameplayEventDispatcher")]
	[UnrealStructLayout(648, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 648)]
	public class UChaosGameplayEventDispatcher : UChaosEventListenerComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003B66 RID: 15206 RVA: 0x000598BE File Offset: 0x00057ABE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChaosGameplayEventDispatcher._ClassPtr;
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x000598CC File Offset: 0x00057ACC
		public UChaosGameplayEventDispatcher() : this(BuiltinUtils.AllocNativeUObject(UChaosGameplayEventDispatcher.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x000598F4 File Offset: 0x00057AF4
		public UChaosGameplayEventDispatcher(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChaosGameplayEventDispatcher.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06003B69 RID: 15209 RVA: 0x00059928 File Offset: 0x00057B28
		// (set) Token: 0x06003B6A RID: 15210 RVA: 0x00059961 File Offset: 0x00057B61
		public TMap<UPrimitiveComponent, FChaosHandlerSet> CollisionEventRegistrations
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UPrimitiveComponent, FChaosHandlerSet> result;
				if ((result = this._CollisionEventRegistrations) == null)
				{
					result = (this._CollisionEventRegistrations = new TMap<UPrimitiveComponent, FChaosHandlerSet>(base.NativePtr + (IntPtr)UChaosGameplayEventDispatcher.__PropertyOffset_CollisionEventRegistrations, this));
				}
				return result;
			}
			set
			{
				this.CollisionEventRegistrations.CopyAssign(value);
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06003B6B RID: 15211 RVA: 0x00059970 File Offset: 0x00057B70
		// (set) Token: 0x06003B6C RID: 15212 RVA: 0x000599A9 File Offset: 0x00057BA9
		public TMap<UPrimitiveComponent, FBreakEventCallbackWrapper> BreakEventRegistrations
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UPrimitiveComponent, FBreakEventCallbackWrapper> result;
				if ((result = this._BreakEventRegistrations) == null)
				{
					result = (this._BreakEventRegistrations = new TMap<UPrimitiveComponent, FBreakEventCallbackWrapper>(base.NativePtr + (IntPtr)UChaosGameplayEventDispatcher.__PropertyOffset_BreakEventRegistrations, this));
				}
				return result;
			}
			set
			{
				this.BreakEventRegistrations.CopyAssign(value);
			}
		}

		// Token: 0x06003B6D RID: 15213 RVA: 0x000599B7 File Offset: 0x00057BB7
		static UChaosGameplayEventDispatcher()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ChaosSolverEngine.ChaosGameplayEventDispatcher");
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x000599C5 File Offset: 0x00057BC5
		protected UChaosGameplayEventDispatcher(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001B55 RID: 6997
		public new const string __ObjectPath = "/Script/ChaosSolverEngine.ChaosGameplayEventDispatcher";

		// Token: 0x04001B56 RID: 6998
		private static IntPtr _ClassPtr;

		// Token: 0x04001B57 RID: 6999
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001B58 RID: 7000
		internal static int __PropertyOffset_CollisionEventRegistrations;

		// Token: 0x04001B59 RID: 7001
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UPrimitiveComponent, FChaosHandlerSet> _CollisionEventRegistrations;

		// Token: 0x04001B5A RID: 7002
		internal static int __PropertyOffset_BreakEventRegistrations;

		// Token: 0x04001B5B RID: 7003
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UPrimitiveComponent, FBreakEventCallbackWrapper> _BreakEventRegistrations;
	}
}
