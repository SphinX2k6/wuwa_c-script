using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000D3 RID: 211
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ActorSequence.ActorSequence")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UActorSequence : UMovieSceneSequence, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600115F RID: 4447 RVA: 0x00019E9E File Offset: 0x0001809E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActorSequence._ClassPtr;
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00019EAC File Offset: 0x000180AC
		public UActorSequence() : this(BuiltinUtils.AllocNativeUObject(UActorSequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00019ED4 File Offset: 0x000180D4
		public UActorSequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActorSequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x00019F07 File Offset: 0x00018107
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x00019F1B File Offset: 0x0001811B
		[Nullable(2)]
		public unsafe UMovieScene MovieScene
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieScene>(base.NativePtr / (IntPtr)sizeof(void*) + UActorSequence.__PropertyOffset_MovieScene);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UActorSequence.__PropertyOffset_MovieScene, value);
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x00019F30 File Offset: 0x00018130
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x00019F69 File Offset: 0x00018169
		public FActorSequenceObjectReferenceMap ObjectReferences
		{
			get
			{
				base.FastCheckIsValid();
				FActorSequenceObjectReferenceMap result;
				if ((result = this._ObjectReferences) == null)
				{
					result = (this._ObjectReferences = new FActorSequenceObjectReferenceMap(base.NativePtr + (IntPtr)UActorSequence.__PropertyOffset_ObjectReferences, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActorSequenceObjectReferenceMap.StaticStruct(), base.NativePtr + (IntPtr)UActorSequence.__PropertyOffset_ObjectReferences, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x00019F8A File Offset: 0x0001818A
		static UActorSequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ActorSequence.ActorSequence");
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00019F98 File Offset: 0x00018198
		protected UActorSequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002A9 RID: 681
		public new const string __ObjectPath = "/Script/ActorSequence.ActorSequence";

		// Token: 0x040002AA RID: 682
		private static IntPtr _ClassPtr;

		// Token: 0x040002AB RID: 683
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002AC RID: 684
		internal static int __PropertyOffset_MovieScene;

		// Token: 0x040002AD RID: 685
		internal static int __PropertyOffset_ObjectReferences;

		// Token: 0x040002AE RID: 686
		[Nullable(2)]
		private FActorSequenceObjectReferenceMap _ObjectReferences;
	}
}
