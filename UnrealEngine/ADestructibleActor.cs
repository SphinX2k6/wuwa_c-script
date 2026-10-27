using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200034D RID: 845
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ApexDestruction.DestructibleActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class ADestructibleActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002EE0 RID: 12000 RVA: 0x00047C54 File Offset: 0x00045E54
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ADestructibleActor._ClassPtr;
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x00047C60 File Offset: 0x00045E60
		public ADestructibleActor() : this(BuiltinUtils.AllocNativeUObject(ADestructibleActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x00047C88 File Offset: 0x00045E88
		public ADestructibleActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ADestructibleActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06002EE3 RID: 12003 RVA: 0x00047CBB File Offset: 0x00045EBB
		// (set) Token: 0x06002EE4 RID: 12004 RVA: 0x00047CCF File Offset: 0x00045ECF
		[Nullable(2)]
		public unsafe UDestructibleComponent DestructibleComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDestructibleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ADestructibleActor.__PropertyOffset_DestructibleComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ADestructibleActor.__PropertyOffset_DestructibleComponent, value);
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x00047CE4 File Offset: 0x00045EE4
		// (set) Token: 0x06002EE6 RID: 12006 RVA: 0x00047D1D File Offset: 0x00045F1D
		public FActorFractureSignature OnActorFracture
		{
			get
			{
				base.FastCheckIsValid();
				FActorFractureSignature result;
				if ((result = this._OnActorFracture) == null)
				{
					result = (this._OnActorFracture = new FActorFractureSignature(base.NativePtr + (IntPtr)ADestructibleActor.__PropertyOffset_OnActorFracture, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ADestructibleActor.__PropertyOffset_OnActorFracture, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x00047D3E File Offset: 0x00045F3E
		static ADestructibleActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ApexDestruction.DestructibleActor");
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x00047D4C File Offset: 0x00045F4C
		protected ADestructibleActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001430 RID: 5168
		public new const string __ObjectPath = "/Script/ApexDestruction.DestructibleActor";

		// Token: 0x04001431 RID: 5169
		private static IntPtr _ClassPtr;

		// Token: 0x04001432 RID: 5170
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001433 RID: 5171
		internal static int __PropertyOffset_DestructibleComponent;

		// Token: 0x04001434 RID: 5172
		internal static int __PropertyOffset_OnActorFracture;

		// Token: 0x04001435 RID: 5173
		[Nullable(2)]
		private FActorFractureSignature _OnActorFracture;
	}
}
