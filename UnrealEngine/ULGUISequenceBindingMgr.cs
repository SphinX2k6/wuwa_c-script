using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020C1 RID: 8385
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUISequenceBindingMgr")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class ULGUISequenceBindingMgr : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F942 RID: 129346 RVA: 0x002EF372 File Offset: 0x002ED572
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUISequenceBindingMgr._ClassPtr;
		}

		// Token: 0x0601F943 RID: 129347 RVA: 0x002EF380 File Offset: 0x002ED580
		public ULGUISequenceBindingMgr() : this(BuiltinUtils.AllocNativeUObject(ULGUISequenceBindingMgr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F944 RID: 129348 RVA: 0x002EF3A8 File Offset: 0x002ED5A8
		public ULGUISequenceBindingMgr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUISequenceBindingMgr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C7B RID: 31867
		// (get) Token: 0x0601F945 RID: 129349 RVA: 0x002EF3DC File Offset: 0x002ED5DC
		// (set) Token: 0x0601F946 RID: 129350 RVA: 0x002EF415 File Offset: 0x002ED615
		public TMap<UMovieSceneSequence, FActorBindings> BindingMaps
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UMovieSceneSequence, FActorBindings> result;
				if ((result = this._BindingMaps) == null)
				{
					result = (this._BindingMaps = new TMap<UMovieSceneSequence, FActorBindings>(base.NativePtr + (IntPtr)ULGUISequenceBindingMgr.__PropertyOffset_BindingMaps, this));
				}
				return result;
			}
			set
			{
				this.BindingMaps.CopyAssign(value);
			}
		}

		// Token: 0x0601F947 RID: 129351 RVA: 0x002EF423 File Offset: 0x002ED623
		static ULGUISequenceBindingMgr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUISequenceBindingMgr");
		}

		// Token: 0x0601F948 RID: 129352 RVA: 0x002EF431 File Offset: 0x002ED631
		protected ULGUISequenceBindingMgr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040110B6 RID: 69814
		public new const string __ObjectPath = "/Script/LGUI.LGUISequenceBindingMgr";

		// Token: 0x040110B7 RID: 69815
		private static IntPtr _ClassPtr;

		// Token: 0x040110B8 RID: 69816
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040110B9 RID: 69817
		internal static int __PropertyOffset_BindingMaps;

		// Token: 0x040110BA RID: 69818
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UMovieSceneSequence, FActorBindings> _BindingMaps;
	}
}
