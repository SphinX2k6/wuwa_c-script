using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A21 RID: 6689
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPhysicsSplit.KuroPhysicsSplitSystem")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UKuroPhysicsSplitSystem : UKuroPhysicsSplitSystemBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018BF5 RID: 101365 RVA: 0x0024925A File Offset: 0x0024745A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPhysicsSplitSystem._ClassPtr;
		}

		// Token: 0x06018BF6 RID: 101366 RVA: 0x00249268 File Offset: 0x00247468
		public UKuroPhysicsSplitSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroPhysicsSplitSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018BF7 RID: 101367 RVA: 0x00249290 File Offset: 0x00247490
		public UKuroPhysicsSplitSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPhysicsSplitSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700621B RID: 25115
		// (get) Token: 0x06018BF8 RID: 101368 RVA: 0x002492C4 File Offset: 0x002474C4
		// (set) Token: 0x06018BF9 RID: 101369 RVA: 0x002492FD File Offset: 0x002474FD
		public TSet<UActorComponent> NoPhysicsCompSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UActorComponent> result;
				if ((result = this._NoPhysicsCompSet) == null)
				{
					result = (this._NoPhysicsCompSet = new TSet<UActorComponent>(base.NativePtr + (IntPtr)UKuroPhysicsSplitSystem.__PropertyOffset_NoPhysicsCompSet, this));
				}
				return result;
			}
			set
			{
				this.NoPhysicsCompSet.CopyAssign(value);
			}
		}

		// Token: 0x1700621C RID: 25116
		// (get) Token: 0x06018BFA RID: 101370 RVA: 0x0024930C File Offset: 0x0024750C
		// (set) Token: 0x06018BFB RID: 101371 RVA: 0x00249345 File Offset: 0x00247545
		public TArray<UActorComponent> ToTickCompList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UActorComponent> result;
				if ((result = this._ToTickCompList) == null)
				{
					result = (this._ToTickCompList = new TArray<UActorComponent>(base.NativePtr + (IntPtr)UKuroPhysicsSplitSystem.__PropertyOffset_ToTickCompList, this));
				}
				return result;
			}
			set
			{
				this.ToTickCompList.CopyAssign(value);
			}
		}

		// Token: 0x06018BFC RID: 101372 RVA: 0x00249353 File Offset: 0x00247553
		[NullableContext(2)]
		public static void StartTickPhysicsStateBP(UWorld World, bool bUseProcessNumPerFrame, int ProcessNumPerFrame)
		{
			UKuroPhysicsSplitSystem.__StartTickPhysicsStateBP_Internal((World != null) ? World.NativePtr : IntPtr.Zero, bUseProcessNumPerFrame, ProcessNumPerFrame);
		}

		// Token: 0x06018BFD RID: 101373 RVA: 0x0024936C File Offset: 0x0024756C
		[NullableContext(2)]
		public static bool IsTickFinishBP(UWorld World)
		{
			return UKuroPhysicsSplitSystem.__IsTickFinishBP_Internal((World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06018BFE RID: 101374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartTickPhysicsStateBP_Internal(IntPtr World, bool bUseProcessNumPerFrame, int ProcessNumPerFrame);

		// Token: 0x06018BFF RID: 101375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsTickFinishBP_Internal(IntPtr World);

		// Token: 0x06018C00 RID: 101376 RVA: 0x00249383 File Offset: 0x00247583
		static UKuroPhysicsSplitSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPhysicsSplit.KuroPhysicsSplitSystem");
		}

		// Token: 0x06018C01 RID: 101377 RVA: 0x00249391 File Offset: 0x00247591
		protected UKuroPhysicsSplitSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D616 RID: 54806
		public new const string __ObjectPath = "/Script/KuroPhysicsSplit.KuroPhysicsSplitSystem";

		// Token: 0x0400D617 RID: 54807
		private static IntPtr _ClassPtr;

		// Token: 0x0400D618 RID: 54808
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D619 RID: 54809
		internal static int __PropertyOffset_NoPhysicsCompSet;

		// Token: 0x0400D61A RID: 54810
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UActorComponent> _NoPhysicsCompSet;

		// Token: 0x0400D61B RID: 54811
		internal static int __PropertyOffset_ToTickCompList;

		// Token: 0x0400D61C RID: 54812
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _ToTickCompList;
	}
}
