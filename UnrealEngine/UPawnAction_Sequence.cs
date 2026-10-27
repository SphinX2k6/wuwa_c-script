using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001DB RID: 475
	[UnrealObjectPath("/Script/AIModule.PawnAction_Sequence")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UPawnAction_Sequence : UPawnAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001C0F RID: 7183 RVA: 0x00029D15 File Offset: 0x00027F15
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPawnAction_Sequence._ClassPtr;
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00029D24 File Offset: 0x00027F24
		public UPawnAction_Sequence() : this(BuiltinUtils.AllocNativeUObject(UPawnAction_Sequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00029D4C File Offset: 0x00027F4C
		[NullableContext(1)]
		public UPawnAction_Sequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPawnAction_Sequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x00029D80 File Offset: 0x00027F80
		// (set) Token: 0x06001C13 RID: 7187 RVA: 0x00029DB9 File Offset: 0x00027FB9
		[Nullable(1)]
		public TArray<UPawnAction> ActionSequence
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UPawnAction> result;
				if ((result = this._ActionSequence) == null)
				{
					result = (this._ActionSequence = new TArray<UPawnAction>(base.NativePtr + (IntPtr)UPawnAction_Sequence.__PropertyOffset_ActionSequence, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActionSequence.CopyAssign(value);
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x00029DC7 File Offset: 0x00027FC7
		// (set) Token: 0x06001C15 RID: 7189 RVA: 0x00029DDB File Offset: 0x00027FDB
		public unsafe TEnumAsByte<EPawnActionFailHandling> ChildFailureHandlingMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnAction_Sequence.__PropertyOffset_ChildFailureHandlingMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnAction_Sequence.__PropertyOffset_ChildFailureHandlingMode) = value;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x00029DF0 File Offset: 0x00027FF0
		// (set) Token: 0x06001C17 RID: 7191 RVA: 0x00029E04 File Offset: 0x00028004
		[Nullable(2)]
		public unsafe UPawnAction RecentActionCopy
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPawnAction>(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction_Sequence.__PropertyOffset_RecentActionCopy);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction_Sequence.__PropertyOffset_RecentActionCopy, value);
			}
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x00029E19 File Offset: 0x00028019
		static UPawnAction_Sequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.PawnAction_Sequence");
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00029E27 File Offset: 0x00028027
		protected UPawnAction_Sequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000915 RID: 2325
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.PawnAction_Sequence";

		// Token: 0x04000916 RID: 2326
		private static IntPtr _ClassPtr;

		// Token: 0x04000917 RID: 2327
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000918 RID: 2328
		internal static int __PropertyOffset_ActionSequence;

		// Token: 0x04000919 RID: 2329
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPawnAction> _ActionSequence;

		// Token: 0x0400091A RID: 2330
		internal static int __PropertyOffset_ChildFailureHandlingMode;

		// Token: 0x0400091B RID: 2331
		internal static int __PropertyOffset_RecentActionCopy;
	}
}
