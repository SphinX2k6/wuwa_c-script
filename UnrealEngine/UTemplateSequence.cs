using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002906 RID: 10502
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TemplateSequence.TemplateSequence")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UTemplateSequence : UMovieSceneSequence, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026F43 RID: 159555 RVA: 0x003B6969 File Offset: 0x003B4B69
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTemplateSequence._ClassPtr;
		}

		// Token: 0x06026F44 RID: 159556 RVA: 0x003B6978 File Offset: 0x003B4B78
		public UTemplateSequence() : this(BuiltinUtils.AllocNativeUObject(UTemplateSequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026F45 RID: 159557 RVA: 0x003B69A0 File Offset: 0x003B4BA0
		public UTemplateSequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTemplateSequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009604 RID: 38404
		// (get) Token: 0x06026F46 RID: 159558 RVA: 0x003B69D3 File Offset: 0x003B4BD3
		// (set) Token: 0x06026F47 RID: 159559 RVA: 0x003B69E7 File Offset: 0x003B4BE7
		[Nullable(2)]
		public unsafe UMovieScene MovieScene
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieScene>(base.NativePtr / (IntPtr)sizeof(void*) + UTemplateSequence.__PropertyOffset_MovieScene);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UTemplateSequence.__PropertyOffset_MovieScene, value);
			}
		}

		// Token: 0x17009605 RID: 38405
		// (get) Token: 0x06026F48 RID: 159560 RVA: 0x003B69FC File Offset: 0x003B4BFC
		// (set) Token: 0x06026F49 RID: 159561 RVA: 0x003B6A11 File Offset: 0x003B4C11
		public TSoftClassPtr<AActor> BoundActorClass
		{
			get
			{
				return new TSoftClassPtr<AActor>(base.NativePtr + (IntPtr)UTemplateSequence.__PropertyOffset_BoundActorClass, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UTemplateSequence.__PropertyOffset_BoundActorClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17009606 RID: 38406
		// (get) Token: 0x06026F4A RID: 159562 RVA: 0x003B6A36 File Offset: 0x003B4C36
		// (set) Token: 0x06026F4B RID: 159563 RVA: 0x003B6A4B File Offset: 0x003B4C4B
		public TSoftObjectPtr<AActor> BoundPreviewActor
		{
			get
			{
				return new TSoftObjectPtr<AActor>(base.NativePtr + (IntPtr)UTemplateSequence.__PropertyOffset_BoundPreviewActor, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UTemplateSequence.__PropertyOffset_BoundPreviewActor, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17009607 RID: 38407
		// (get) Token: 0x06026F4C RID: 159564 RVA: 0x003B6A70 File Offset: 0x003B4C70
		// (set) Token: 0x06026F4D RID: 159565 RVA: 0x003B6AA9 File Offset: 0x003B4CA9
		public TMap<FGuid, FName> BoundActorComponents
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, FName> result;
				if ((result = this._BoundActorComponents) == null)
				{
					result = (this._BoundActorComponents = new TMap<FGuid, FName>(base.NativePtr + (IntPtr)UTemplateSequence.__PropertyOffset_BoundActorComponents, this));
				}
				return result;
			}
			set
			{
				this.BoundActorComponents.CopyAssign(value);
			}
		}

		// Token: 0x06026F4E RID: 159566 RVA: 0x003B6AB7 File Offset: 0x003B4CB7
		static UTemplateSequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TemplateSequence.TemplateSequence");
		}

		// Token: 0x06026F4F RID: 159567 RVA: 0x003B6AC5 File Offset: 0x003B4CC5
		protected UTemplateSequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015610 RID: 87568
		public new const string __ObjectPath = "/Script/TemplateSequence.TemplateSequence";

		// Token: 0x04015611 RID: 87569
		private static IntPtr _ClassPtr;

		// Token: 0x04015612 RID: 87570
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015613 RID: 87571
		internal static int __PropertyOffset_MovieScene;

		// Token: 0x04015614 RID: 87572
		internal static int __PropertyOffset_BoundActorClass;

		// Token: 0x04015615 RID: 87573
		internal static int __PropertyOffset_BoundPreviewActor;

		// Token: 0x04015616 RID: 87574
		internal static int __PropertyOffset_BoundActorComponents;

		// Token: 0x04015617 RID: 87575
		[Nullable(2)]
		private TMap<FGuid, FName> _BoundActorComponents;
	}
}
