using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000382 RID: 898
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroFastCollision.KuroFastCollisionSubsystem")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroFastCollisionSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005A4B RID: 23115 RVA: 0x0007FA8D File Offset: 0x0007DC8D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFastCollisionSubsystem._ClassPtr;
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x0007FA9C File Offset: 0x0007DC9C
		public UKuroFastCollisionSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x0007FAC4 File Offset: 0x0007DCC4
		public UKuroFastCollisionSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFastCollisionSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x06005A4E RID: 23118 RVA: 0x0007FAF8 File Offset: 0x0007DCF8
		// (set) Token: 0x06005A4F RID: 23119 RVA: 0x0007FB31 File Offset: 0x0007DD31
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

		// Token: 0x06005A50 RID: 23120 RVA: 0x0007FB3F File Offset: 0x0007DD3F
		[NullableContext(2)]
		public static UKuroFastCollisionSubsystem Get(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroFastCollisionSubsystem>(UKuroFastCollisionSubsystem.__Get_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x0007FB5B File Offset: 0x0007DD5B
		[NullableContext(2)]
		public void DestroyAlgorithm(UKuroFastCollisionAlgorithm Algorithm)
		{
			UKuroFastCollisionSubsystem.__DestroyAlgorithm_Internal(base.NativePtr, (Algorithm != null) ? Algorithm.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005A52 RID: 23122 RVA: 0x0007FB78 File Offset: 0x0007DD78
		[NullableContext(2)]
		public UKuroFastCollisionAlgorithm CreateAlgorithm([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UKuroFastCollisionAlgorithm> AlgorithmClass, bool bTickEnabled = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroFastCollisionAlgorithm>(UKuroFastCollisionSubsystem.__CreateAlgorithm_Internal(base.NativePtr, AlgorithmClass._NativePtr, bTickEnabled));
		}

		// Token: 0x06005A53 RID: 23123
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Get_Internal(IntPtr WorldContextObject);

		// Token: 0x06005A54 RID: 23124
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyAlgorithm_Internal(IntPtr @this, IntPtr Algorithm);

		// Token: 0x06005A55 RID: 23125
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateAlgorithm_Internal(IntPtr @this, IntPtr AlgorithmClass, bool bTickEnabled);

		// Token: 0x06005A56 RID: 23126 RVA: 0x0007FB91 File Offset: 0x0007DD91
		static UKuroFastCollisionSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFastCollision.KuroFastCollisionSubsystem");
		}

		// Token: 0x06005A57 RID: 23127 RVA: 0x0007FB9F File Offset: 0x0007DD9F
		protected UKuroFastCollisionSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002585 RID: 9605
		public new const string __ObjectPath = "/Script/KuroFastCollision.KuroFastCollisionSubsystem";

		// Token: 0x04002586 RID: 9606
		private static IntPtr _ClassPtr;

		// Token: 0x04002587 RID: 9607
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002588 RID: 9608
		internal static int __PropertyOffset_LiveAlgorithms;

		// Token: 0x04002589 RID: 9609
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UKuroFastCollisionAlgorithm> _LiveAlgorithms;
	}
}
