using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200057E RID: 1406
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public abstract class UKSC_Move : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007FD3 RID: 32723 RVA: 0x000BD038 File Offset: 0x000BB238
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move._ClassPtr;
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06007FD4 RID: 32724 RVA: 0x000BD044 File Offset: 0x000BB244
		// (set) Token: 0x06007FD5 RID: 32725 RVA: 0x000BD058 File Offset: 0x000BB258
		[Nullable(2)]
		public unsafe AKSC_Entity Owner_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKSC_Entity>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move.__PropertyOffset_Owner_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Move.__PropertyOffset_Owner_, value);
			}
		}

		// Token: 0x06007FD6 RID: 32726 RVA: 0x000BD06D File Offset: 0x000BB26D
		static UKSC_Move()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move");
		}

		// Token: 0x06007FD7 RID: 32727 RVA: 0x000BD07C File Offset: 0x000BB27C
		protected UKSC_Move() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007FD8 RID: 32728 RVA: 0x000BD0A4 File Offset: 0x000BB2A4
		protected UKSC_Move(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040037D2 RID: 14290
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move";

		// Token: 0x040037D3 RID: 14291
		private static IntPtr _ClassPtr;

		// Token: 0x040037D4 RID: 14292
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040037D5 RID: 14293
		internal static int __PropertyOffset_Owner_;
	}
}
