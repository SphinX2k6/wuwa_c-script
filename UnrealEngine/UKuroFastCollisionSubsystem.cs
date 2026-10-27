using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001837 RID: 6199
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroFastCollision.KuroFastCollisionSubsystem")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroFastCollisionSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016DC4 RID: 93636 RVA: 0x00215FE8 File Offset: 0x002141E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFastCollisionSubsystem._ClassPtr;
		}

		// Token: 0x06016DC5 RID: 93637 RVA: 0x00215FF4 File Offset: 0x002141F4
		public UKuroFastCollisionSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016DC6 RID: 93638 RVA: 0x0021601C File Offset: 0x0021421C
		public UKuroFastCollisionSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C43 RID: 23619
		// (get) Token: 0x06016DC7 RID: 93639 RVA: 0x00216050 File Offset: 0x00214250
		// (set) Token: 0x06016DC8 RID: 93640 RVA: 0x00216089 File Offset: 0x00214289
		public TSet<UKuroFastCollisionAlgorithm> LiveAlgorithms
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UKuroFastCollisionAlgorithm> result;
				if ((result = this._LiveAlgorithms) == null)
				{
					result = (this._LiveAlgorithms = new TSet<UKuroFastCollisionAlgorithm>(base.NativePtr + (IntPtr)UKuroFastCollisionSubsystem.__PropertyOffset_LiveAlgorithms, this));
				}
				return result;
			}
			set
			{
				this.LiveAlgorithms.CopyAssign(value);
			}
		}

		// Token: 0x06016DC9 RID: 93641 RVA: 0x00216097 File Offset: 0x00214297
		[NullableContext(2)]
		public static UKuroFastCollisionSubsystem Get(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroFastCollisionSubsystem>(UKuroFastCollisionSubsystem.__Get_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06016DCA RID: 93642 RVA: 0x002160B3 File Offset: 0x002142B3
		[NullableContext(2)]
		public void DestroyAlgorithm(UKuroFastCollisionAlgorithm Algorithm)
		{
			UKuroFastCollisionSubsystem.__DestroyAlgorithm_Internal(base.NativePtr, (Algorithm != null) ? Algorithm.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06016DCB RID: 93643 RVA: 0x002160D0 File Offset: 0x002142D0
		[NullableContext(2)]
		public UKuroFastCollisionAlgorithm CreateAlgorithm([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UKuroFastCollisionAlgorithm> AlgorithmClass, bool bTickEnabled = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroFastCollisionAlgorithm>(UKuroFastCollisionSubsystem.__CreateAlgorithm_Internal(base.NativePtr, AlgorithmClass._NativePtr, bTickEnabled));
		}

		// Token: 0x06016DCC RID: 93644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Get_Internal(IntPtr WorldContextObject);

		// Token: 0x06016DCD RID: 93645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyAlgorithm_Internal(IntPtr @this, IntPtr Algorithm);

		// Token: 0x06016DCE RID: 93646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateAlgorithm_Internal(IntPtr @this, IntPtr AlgorithmClass, bool bTickEnabled);

		// Token: 0x06016DCF RID: 93647 RVA: 0x002160E9 File Offset: 0x002142E9
		static UKuroFastCollisionSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFastCollision.KuroFastCollisionSubsystem");
		}

		// Token: 0x06016DD0 RID: 93648 RVA: 0x002160F7 File Offset: 0x002142F7
		protected UKuroFastCollisionSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C6D4 RID: 50900
		public new const string __ObjectPath = "/Script/KuroFastCollision.KuroFastCollisionSubsystem";

		// Token: 0x0400C6D5 RID: 50901
		private static IntPtr _ClassPtr;

		// Token: 0x0400C6D6 RID: 50902
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C6D7 RID: 50903
		internal static int __PropertyOffset_LiveAlgorithms;

		// Token: 0x0400C6D8 RID: 50904
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UKuroFastCollisionAlgorithm> _LiveAlgorithms;
	}
}
