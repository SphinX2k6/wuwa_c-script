using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020DD RID: 8413
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIUpdateGeometryHelper")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class ULGUIUpdateGeometryHelper : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FAE0 RID: 129760 RVA: 0x002F1F0E File Offset: 0x002F010E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIUpdateGeometryHelper._ClassPtr;
		}

		// Token: 0x0601FAE1 RID: 129761 RVA: 0x002F1F1C File Offset: 0x002F011C
		public ULGUIUpdateGeometryHelper() : this(BuiltinUtils.AllocNativeUObject(ULGUIUpdateGeometryHelper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FAE2 RID: 129762 RVA: 0x002F1F44 File Offset: 0x002F0144
		public ULGUIUpdateGeometryHelper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIUpdateGeometryHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007CDB RID: 31963
		// (get) Token: 0x0601FAE3 RID: 129763 RVA: 0x002F1F78 File Offset: 0x002F0178
		// (set) Token: 0x0601FAE4 RID: 129764 RVA: 0x002F1FB1 File Offset: 0x002F01B1
		public TArray<FLGUIGeometryVertex> cacheVertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLGUIGeometryVertex> result;
				if ((result = this._cacheVertices) == null)
				{
					result = (this._cacheVertices = new TArray<FLGUIGeometryVertex>(base.NativePtr + (IntPtr)ULGUIUpdateGeometryHelper.__PropertyOffset_cacheVertices, this));
				}
				return result;
			}
			set
			{
				this.cacheVertices.CopyAssign(value);
			}
		}

		// Token: 0x0601FAE5 RID: 129765 RVA: 0x002F1FBF File Offset: 0x002F01BF
		public void EndUpdateVertices()
		{
			ULGUIUpdateGeometryHelper.__EndUpdateVertices_Internal(base.NativePtr);
		}

		// Token: 0x0601FAE6 RID: 129766 RVA: 0x002F1FCC File Offset: 0x002F01CC
		public void BeginUpdateVertices()
		{
			ULGUIUpdateGeometryHelper.__BeginUpdateVertices_Internal(base.NativePtr);
		}

		// Token: 0x0601FAE7 RID: 129767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndUpdateVertices_Internal(IntPtr @this);

		// Token: 0x0601FAE8 RID: 129768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginUpdateVertices_Internal(IntPtr @this);

		// Token: 0x0601FAE9 RID: 129769 RVA: 0x002F1FD9 File Offset: 0x002F01D9
		static ULGUIUpdateGeometryHelper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIUpdateGeometryHelper");
		}

		// Token: 0x0601FAEA RID: 129770 RVA: 0x002F1FE7 File Offset: 0x002F01E7
		protected ULGUIUpdateGeometryHelper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011177 RID: 70007
		public new const string __ObjectPath = "/Script/LGUI.LGUIUpdateGeometryHelper";

		// Token: 0x04011178 RID: 70008
		private static IntPtr _ClassPtr;

		// Token: 0x04011179 RID: 70009
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401117A RID: 70010
		internal static int __PropertyOffset_cacheVertices;

		// Token: 0x0401117B RID: 70011
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLGUIGeometryVertex> _cacheVertices;
	}
}
