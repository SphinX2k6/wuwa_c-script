using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200201E RID: 8222
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIAtlasManager")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class ULGUIAtlasManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EFA6 RID: 126886 RVA: 0x002E1156 File Offset: 0x002DF356
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIAtlasManager._ClassPtr;
		}

		// Token: 0x0601EFA7 RID: 126887 RVA: 0x002E1164 File Offset: 0x002DF364
		public ULGUIAtlasManager() : this(BuiltinUtils.AllocNativeUObject(ULGUIAtlasManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EFA8 RID: 126888 RVA: 0x002E118C File Offset: 0x002DF38C
		public ULGUIAtlasManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIAtlasManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007B4D RID: 31565
		// (get) Token: 0x0601EFA9 RID: 126889 RVA: 0x002E11C0 File Offset: 0x002DF3C0
		// (set) Token: 0x0601EFAA RID: 126890 RVA: 0x002E11F9 File Offset: 0x002DF3F9
		public TMap<FName, FLGUIAtlasData> atlasMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLGUIAtlasData> result;
				if ((result = this._atlasMap) == null)
				{
					result = (this._atlasMap = new TMap<FName, FLGUIAtlasData>(base.NativePtr + (IntPtr)ULGUIAtlasManager.__PropertyOffset_atlasMap, this));
				}
				return result;
			}
			set
			{
				this.atlasMap.CopyAssign(value);
			}
		}

		// Token: 0x0601EFAB RID: 126891
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DisposeAtlasByPackingTag(FName inPackingTag);

		// Token: 0x0601EFAC RID: 126892 RVA: 0x002E1207 File Offset: 0x002DF407
		static ULGUIAtlasManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIAtlasManager");
		}

		// Token: 0x0601EFAD RID: 126893 RVA: 0x002E1215 File Offset: 0x002DF415
		protected ULGUIAtlasManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D73 RID: 68979
		public new const string __ObjectPath = "/Script/LGUI.LGUIAtlasManager";

		// Token: 0x04010D74 RID: 68980
		private static IntPtr _ClassPtr;

		// Token: 0x04010D75 RID: 68981
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D76 RID: 68982
		internal static int __PropertyOffset_atlasMap;

		// Token: 0x04010D77 RID: 68983
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FLGUIAtlasData> _atlasMap;
	}
}
