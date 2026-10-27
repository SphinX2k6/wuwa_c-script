using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B03 RID: 6915
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFoliageRemoverActor")]
	[UnrealStructLayout(1456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1456)]
	public class AKuroFoliageRemoverActor : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019E12 RID: 106002 RVA: 0x0026353E File Offset: 0x0026173E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroFoliageRemoverActor._ClassPtr;
		}

		// Token: 0x06019E13 RID: 106003 RVA: 0x0026354C File Offset: 0x0026174C
		public AKuroFoliageRemoverActor() : this(BuiltinUtils.AllocNativeUObject(AKuroFoliageRemoverActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019E14 RID: 106004 RVA: 0x00263574 File Offset: 0x00261774
		[NullableContext(1)]
		public AKuroFoliageRemoverActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroFoliageRemoverActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06019E15 RID: 106005 RVA: 0x002635A7 File Offset: 0x002617A7
		public void Update()
		{
			AKuroFoliageRemoverActor.__Update_Internal(base.NativePtr);
		}

		// Token: 0x06019E16 RID: 106006 RVA: 0x002635B4 File Offset: 0x002617B4
		public void SetVersionNumbers(int MajorVersion, int MinorVersion)
		{
			AKuroFoliageRemoverActor.__SetVersionNumbers_Internal(base.NativePtr, MajorVersion, MinorVersion);
		}

		// Token: 0x06019E17 RID: 106007 RVA: 0x002635C3 File Offset: 0x002617C3
		public void RemoveCrushedAllInstances()
		{
			AKuroFoliageRemoverActor.__RemoveCrushedAllInstances_Internal(base.NativePtr);
		}

		// Token: 0x06019E18 RID: 106008 RVA: 0x002635D0 File Offset: 0x002617D0
		public void RecoverAllInstances()
		{
			AKuroFoliageRemoverActor.__RecoverAllInstances_Internal(base.NativePtr);
		}

		// Token: 0x06019E19 RID: 106009 RVA: 0x002635DD File Offset: 0x002617DD
		public void HideAllInstances()
		{
			AKuroFoliageRemoverActor.__HideAllInstances_Internal(base.NativePtr);
		}

		// Token: 0x06019E1A RID: 106010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Update_Internal(IntPtr @this);

		// Token: 0x06019E1B RID: 106011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVersionNumbers_Internal(IntPtr @this, int MajorVersion, int MinorVersion);

		// Token: 0x06019E1C RID: 106012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveCrushedAllInstances_Internal(IntPtr @this);

		// Token: 0x06019E1D RID: 106013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RecoverAllInstances_Internal(IntPtr @this);

		// Token: 0x06019E1E RID: 106014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HideAllInstances_Internal(IntPtr @this);

		// Token: 0x06019E1F RID: 106015 RVA: 0x002635EA File Offset: 0x002617EA
		static AKuroFoliageRemoverActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFoliageRemoverActor");
		}

		// Token: 0x06019E20 RID: 106016 RVA: 0x002635F8 File Offset: 0x002617F8
		protected AKuroFoliageRemoverActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E11F RID: 57631
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFoliageRemoverActor";

		// Token: 0x0400E120 RID: 57632
		private static IntPtr _ClassPtr;

		// Token: 0x0400E121 RID: 57633
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
